using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Models
{
    public class DailySaleRow
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string StaffName { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
