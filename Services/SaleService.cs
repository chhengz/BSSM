using bookshopsystem.Forms;
using bookshopsystem.Models;
using bookshopsystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Services
{
    public class SaleService
    {
        private readonly SaleRepository _repo = new SaleRepository();

        public int Checkout(int staffId, IEnumerable<OrderItem> items)
        {
            var sale = new Sale
            {
                StaffId = staffId,
                TotalAmount = items.Sum(i => i.Subtotal)
            };

            var details = items.Select(i => new SaleDetail
            {
                BookId = i.Book.BookId,
                Quantity = i.Quantity,
                UnitPrice = i.Book.Price
            }).ToList();

            return _repo.CreateSale(sale, details);
        }
    }
}
