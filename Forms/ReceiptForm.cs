using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class ReceiptForm : Form
    {
        private readonly Receipt _receipt;
        //private ListView lvItems;

        private const decimal RIEL_RATE = 4100m;

        public ReceiptForm(Receipt receipt)
        {
            _receipt = receipt ?? throw new ArgumentNullException(nameof(receipt));
            InitializeComponent();

            LoadReceiptData();
            BuildBottomUI();
        }

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

        //private void LoadReceiptData()
        //{
        //    int index = 1;
        //    foreach (var item in _receipt.Items)
        //    {

        //        index++;
        //        var lvi = new ListViewItem(item.Title.Length > 30 ? item.Title.Substring(0, 27) + "..." : item.Title);
        //        lvi.SubItems.Add(item.Quantity.ToString());
        //        lvi.SubItems.Add(item.Price.ToString("N2"));
        //        //lvi.SubItems.Add(item.Subtotal.ToString("N2"));
        //        lvReceipt.Items.Add(lvi);
        //    }
        //}

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

            // Optional: update receipt total
            _receipt.Total = _receipt.Items.Sum(x => x.Subtotal);
        }



        //private Label CreateLabel(string text, FontStyle style = FontStyle.Regular, float size = 10)
        //{
        //    return new Label
        //    {
        //        Text = text,
        //        AutoSize = true,
        //        Font = new Font("Segoe UI", size, style),
        //        Margin = new Padding(0, 4, 0, 4)
        //    };
        //}
    }


    public class Receipt
    {
        public int ReceiptId { get; set; }
        public DateTime Date { get; set; }
        public List<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();
        public decimal Total { get; set; }
    }



    public class ReceiptItem
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal => Price * Quantity;
    }
}
