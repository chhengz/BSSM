using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Core.Patterns
{
    public class CsvAdapter
    {
        public string FromGrid(DataGridView grid)
        {
            var sb = new StringBuilder();

            foreach (DataGridViewColumn col in grid.Columns)
                sb.Append(col.HeaderText + ",");

            sb.Length--;
            sb.AppendLine();

            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    sb.Append(cell.Value + ",");

                sb.Length--;
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }


}
