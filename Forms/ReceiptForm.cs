using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class ReceiptForm : Form
    {
        private readonly Receipt _receipt;
        private PrintDocument printDocument = new PrintDocument();
        private const decimal RIEL_RATE = 4100m; // 1 USD = 4100 RIEL (example exchange rate)

        // ===================== ReceiptForm Constructor =====================
        public ReceiptForm(Receipt receipt)
        {
            _receipt = receipt ?? throw new ArgumentNullException(nameof(receipt));
            InitializeComponent();

            LoadReceiptData();
            BuildBottomUI();
        }

        // ===================== Build Bottom UI (Subtotal, Tax, Grand Total) =====================
        private void BuildBottomUI()
        {
            decimal subtotal = _receipt.Items.Sum(i => i.Subtotal);
            decimal tax = subtotal * 0.1m;
            decimal grand = subtotal + tax;

            lb_ST.Text = $"{subtotal:N2} $";
            lb_TAX.Text = $"{tax:N2} $";
            lb_GKH.Text = $"{(grand * RIEL_RATE):N0} ៛";
            lb_GUSD.Text = $"{grand:N2} $";
            receipt_ID.Text = $"Receipt #{_receipt.ReceiptId} • {_receipt.Date:yyyy-MM-dd HH:mm}";
        }

        // ===================== Load Receipt Data into ListView =====================
        private void LoadReceiptData()
        {
            lvReceipt.Items.Clear();
            int index = 1;

            foreach (var item in _receipt.Items)
            {
                var lvi = new ListViewItem(index.ToString()); // #

                // Title
                lvi.SubItems.Add(item.Title.Length > 30
                    ? item.Title.Substring(0, 27) + "..."
                    : item.Title);

                // Qty
                lvi.SubItems.Add(item.Quantity.ToString());

                // Price
                lvi.SubItems.Add(item.Price.ToString("N2"));

                // Total (Subtotal)
                lvi.SubItems.Add(item.Subtotal.ToString("N2"));

                lvReceipt.Items.Add(lvi);

                index++;
            }

             // update receipt total
            _receipt.Total = _receipt.Items.Sum(x => x.Subtotal);
        }

        // ===================== Button Print Receipt =====================
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        // ===================== Print Page Event Handler =====================
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Font font = new Font("Arial", 10);
            //Font boldFont = new Font("Arial", 12, FontStyle.Bold);

            Graphics g = e.Graphics;
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
            System.Drawing.Font boldFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);


            int y = 20;

            g.DrawString("BOOK SHOP", boldFont, Brushes.Black, 250, y);
            y += 30;

            g.DrawString($"Receipt #{_receipt.ReceiptId}", font, Brushes.Black, 20, y);
            y += 20;
            g.DrawString($"{_receipt.Date:yyyy-MM-dd HH:mm}", font, Brushes.Black, 20, y);
            y += 30;

            g.DrawString("----------------------------------------------------------", font, Brushes.Black, 20, y);
            y += 20;

            foreach (var item in _receipt.Items)
            {
                g.DrawString(item.Title, font, Brushes.Black, 20, y);
                g.DrawString($"{item.Quantity} x {item.Price:N2}", font, Brushes.Black, 300, y);
                g.DrawString($"{item.Subtotal:N2}", font, Brushes.Black, 420, y);
                y += 20;
            }

            y += 20;
            g.DrawString("----------------------------------------------------------", font, Brushes.Black, 20, y);
            y += 25;

            decimal subtotal = _receipt.Items.Sum(i => i.Subtotal);
            decimal tax = subtotal * 0.1m;
            decimal grand = subtotal + tax;

            g.DrawString($"Subtotal: {subtotal:N2} $", font, Brushes.Black, 300, y);
            y += 20;
            g.DrawString($"Tax (10%): {tax:N2} $", font, Brushes.Black, 300, y);
            y += 20;
            g.DrawString($"Grand Total: {grand:N2} $", boldFont, Brushes.Black, 300, y);
        }


        // ===================== Button Print PDF =====================
        private void btnPrintPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File|*.pdf";
            save.Title = "Save Receipt as PDF";
            save.FileName = $"Receipt_{_receipt.ReceiptId}.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new System.IO.FileStream(save.FileName, System.IO.FileMode.Create));
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                doc.Add(new Paragraph("BOOK SHOP", titleFont));
                doc.Add(new Paragraph($"Receipt #{_receipt.ReceiptId}", normalFont));
                doc.Add(new Paragraph($"{_receipt.Date:yyyy-MM-dd HH:mm}", normalFont));
                doc.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;

                table.AddCell("Item");
                table.AddCell("Qty");
                table.AddCell("Price");
                table.AddCell("Total");

                foreach (var item in _receipt.Items)
                {
                    table.AddCell(item.Title);
                    table.AddCell(item.Quantity.ToString());
                    table.AddCell(item.Price.ToString("N2"));
                    table.AddCell(item.Subtotal.ToString("N2"));
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));

                decimal subtotal = _receipt.Items.Sum(i => i.Subtotal);
                decimal tax = subtotal * 0.1m;
                decimal grand = subtotal + tax;

                doc.Add(new Paragraph($"Subtotal: {subtotal:N2} $"));
                doc.Add(new Paragraph($"Tax (10%): {tax:N2} $"));
                doc.Add(new Paragraph($"Grand Total (USD): {grand:N2} $"));
                doc.Add(new Paragraph($"Grand Total (KHR): {(grand * RIEL_RATE):N0} ៛"));

                doc.Close();

                MessageBox.Show("PDF saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // Represents the receipt data model
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public DateTime Date { get; set; }
        public List<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();
        public decimal Total { get; set; }
    }

    // Represents an individual item in the receipt
    public class ReceiptItem
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal => Price * Quantity;
    }
}
