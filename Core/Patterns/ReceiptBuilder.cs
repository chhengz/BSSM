using bookshopsystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Core.Patterns
{
    public class ReceiptBuilder
    {
        private Receipt _receipt = new Receipt();

        public ReceiptBuilder SetInfo(int id, DateTime date)
        {
            _receipt.ReceiptId = id;
            _receipt.Date = date;
            return this;
        }

        public ReceiptBuilder AddItem(string title, int qty, decimal price)
        {
            _receipt.Items.Add(new ReceiptItem
            {
                Title = title,
                Quantity = qty,
                Price = price
            });
            return this;
        }

        public Receipt Build()
        {
            return _receipt;
        }
    }



}
