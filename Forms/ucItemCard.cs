using bookshopsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class ucItemCard : UserControl
    {
        public OrderItem Item { get; private set; }

        public event EventHandler QuantityChanged;
        public event EventHandler RemoveRequested;

        public ucItemCard(OrderItem item)
        {
            InitializeComponent();
            Item = item;
            UpdateUI();
        }

        // ===================== UPDATE UI =====================
        private void UpdateUI()
        {
            lblName.Text = Item.Book.Title;
            lblQty.Text = Item.Quantity.ToString();
            lblPrice.Text = Item.Subtotal.ToString("N2");
        }


        // ===================== MINUS BOOKS =====================
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Item.Quantity--;

            if (Item.Quantity <= 0)
            {
                RemoveRequested?.Invoke(this, EventArgs.Empty);
                return;
            }

            UpdateUI();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        // ===================== PLUS BOOKS =====================
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Item.Quantity + 1 > Item.Book.Stock)
            {
                MessageBox.Show($"Cannot add more – only {Item.Book.Stock} in stock.",
                    "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item.Quantity++;
            UpdateUI();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }
    }


    // ===================== CLASS OrderItem =====================
    public class OrderItem
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal => Book.Price * Quantity;
    }



}
