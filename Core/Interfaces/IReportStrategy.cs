using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Core.Interfaces
{
    public interface IReportStrategy
    {
        void Generate();
        DataTable Generate(DateTime from, DateTime to);
    }
}
