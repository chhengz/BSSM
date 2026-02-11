using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int StaffId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
