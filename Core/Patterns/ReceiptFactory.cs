using bookshopsystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Core.Patterns
{
    public static class ReceiptFactory
    {
        public static Receipt Create(int id)
        {
            return new Receipt { ReceiptId = id, Date = DateTime.Now };
        }
    }

}
