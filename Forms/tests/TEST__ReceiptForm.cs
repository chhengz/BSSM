using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class TEST__ReceiptForm : Form
    {
        private readonly Receipt _receipt;
        private PrintDocument printDocument;

        // Receipt layout settings (adjust for your thermal printer paper width)
        private const float PAPER_WIDTH_MM = 80f;         
        private const int DPI = 96;                       
        private const float LEFT_MARGIN = 10f;
        private const float LINE_HEIGHT = 20f;
        private float currentY = 0f;

        public TEST__ReceiptForm(Receipt receipt)
        {
            _receipt = receipt ?? throw new ArgumentNullException(nameof(receipt));

            this.Text = $"Receipt #{receipt.ReceiptId}";
            this.Size = new Size(500, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            InitializePrintDocument();
            InitializeUI();
        }

        private void InitializePrintDocument()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
}

        private void InitializeUI()
        {
            // Simple preview-like layout (optional - you can show DataGridView too)
            var btnPrint = new Button { Text = "Print Receipt", Location = new Point(20, 20), Width = 140 };
            var btnSavePdf = new Button { Text = "Save as PDF", Location = new Point(180, 20), Width = 140 };
            var btnClose = new Button { Text = "Close", Location = new Point(340, 20), Width = 120 };

            btnPrint.Click += BtnPrint_Click;
            btnSavePdf.Click += BtnSavePdf_Click;
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(btnPrint);
            this.Controls.Add(btnSavePdf);
            this.Controls.Add(btnClose);

            // Optional: show simple preview text or DataGridView here
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            using (var printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                printDialog.UseEXDialog = true;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument.Print();
                        MessageBox.Show("Sent to printer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Print error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnSavePdf_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Save Receipt as PDF";
                saveDialog.FileName = $"Receipt_{_receipt.ReceiptId}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Use Microsoft Print to PDF (built-in Windows 10/11)
                        printDocument.PrinterSettings = new PrinterSettings
                        {
                            PrinterName = "Microsoft Print to PDF",
                            PrintFileName = saveDialog.FileName,
                            PrintToFile = true
                        };

                        printDocument.Print();
                        MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            currentY = 10f; // start position

            // Use smaller font for thermal printers
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font smallFont = new Font("Arial", 9);

            float pageWidth = e.PageBounds.Width - (LEFT_MARGIN * 2);

            // ── Header ───────────────────────────────────────────────
            DrawCenteredText(g, "BOOK SHOP", headerFont, pageWidth);
            currentY += LINE_HEIGHT;
            DrawCenteredText(g, "Thank you for shopping!", normalFont, pageWidth);
            currentY += LINE_HEIGHT * 1.2f;

            DrawLine(g, pageWidth);
            currentY += LINE_HEIGHT;

            // Receipt info
            g.DrawString($"Receipt # {_receipt.ReceiptId}", normalFont, Brushes.Black, LEFT_MARGIN, currentY);
            currentY += LINE_HEIGHT;
            g.DrawString($"{_receipt.Date:yyyy-MM-dd HH:mm}", normalFont, Brushes.Black, LEFT_MARGIN, currentY);
            currentY += LINE_HEIGHT * 1.5f;

            // ── Table Header ─────────────────────────────────────────
            g.DrawString("Item", normalFont, Brushes.Black, LEFT_MARGIN, currentY);
            g.DrawString("Qty", normalFont, Brushes.Black, pageWidth - 180, currentY);
            g.DrawString("Price", normalFont, Brushes.Black, pageWidth - 120, currentY);
            g.DrawString("Total", normalFont, Brushes.Black, pageWidth - 60, currentY);
            currentY += LINE_HEIGHT;

            DrawLine(g, pageWidth);
            currentY += 8f;

            // ── Items ────────────────────────────────────────────────
            foreach (var item in _receipt.Items)
            {
                g.DrawString(Truncate(item.Title, 30), normalFont, Brushes.Black, LEFT_MARGIN, currentY);

                string qtyStr = item.Quantity.ToString();
                string priceStr = item.Price.ToString("N2");
                string totalStr = item.Subtotal.ToString("N2");

                g.DrawString(qtyStr, normalFont, Brushes.Black, pageWidth - 180, currentY);
                g.DrawString(priceStr, normalFont, Brushes.Black, pageWidth - 120, currentY);
                g.DrawString(totalStr, normalFont, Brushes.Black, pageWidth - 60, currentY);

                currentY += LINE_HEIGHT;
            }

            DrawLine(g, pageWidth);
            currentY += LINE_HEIGHT;

            // ── Summary ──────────────────────────────────────────────
            decimal subtotal = _receipt.Items.Sum(i => i.Subtotal);


            decimal tax = subtotal * 0.1m;
            decimal grand = subtotal + tax;
            const decimal RIEL_RATE = 4100m;

            DrawRightAligned(g, $"Subtotal:", subtotal.ToString("N0") + " $", normalFont, pageWidth);
            DrawRightAligned(g, $"Tax (10%):", tax.ToString("N0") + " $", normalFont, pageWidth);
            currentY += 8f;
            DrawRightAligned(g, $"Grand Total (KHR):", (grand * RIEL_RATE).ToString("N0") + " ៛", new Font("Arial", 11, FontStyle.Bold), pageWidth);
            DrawRightAligned(g, $"Grand Total (USD):", grand.ToString("N2") + " $", normalFont, pageWidth);

            currentY += LINE_HEIGHT * 2;

            // Footer
            DrawCenteredText(g, "Thank you! Come again ❤️", smallFont, pageWidth);
            currentY += LINE_HEIGHT;

            // Tell PrintDocument if more pages needed (rare for receipts)
            e.HasMorePages = false;
        }

        // Helper methods
        private void DrawCenteredText(Graphics g, string text, Font font, float pageWidth)
        {
            SizeF size = g.MeasureString(text, font);
            float x = (pageWidth - size.Width) / 2 + LEFT_MARGIN;
            g.DrawString(text, font, Brushes.Black, x, currentY);
            currentY += LINE_HEIGHT;
        }

        private void DrawRightAligned(Graphics g, string label, string value, Font font, float pageWidth)
        {
            g.DrawString(label, font, Brushes.Black, LEFT_MARGIN, currentY);

            SizeF valSize = g.MeasureString(value, font);
            g.DrawString(value, font, Brushes.Black, pageWidth - valSize.Width, currentY);

            currentY += LINE_HEIGHT;
        }

        private void DrawLine(Graphics g, float pageWidth)
        {
            g.DrawLine(Pens.Black, LEFT_MARGIN, currentY, pageWidth + LEFT_MARGIN, currentY);
        }

        private string Truncate(string text, int maxLength)
        {
            return text.Length > maxLength ? text.Substring(0, maxLength - 3) + "..." : text;
        }
    }
}