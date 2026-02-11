using bookshopsystem.Models;
using bookshopsystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Services
{
    public class ReportService
    {
        private readonly ReportRepository _repo = new ReportRepository();

        public List<DailySaleRow> GetDailySales(DateTime date)
            => _repo.GetDailySales(date);

        public List<DailySaleRow> GetMonthlySales(int year, int month)
            => _repo.GetMonthlySales(year, month);

        public List<DailySaleRow> GetYearlySales(int year)
            => _repo.GetYearlySales(year);

        public List<DailySaleRow> GetSalesByRange(DateTime from, DateTime to)
            => _repo.GetSalesByRange(from, to);
    }
}
