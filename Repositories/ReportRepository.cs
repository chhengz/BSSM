using bookshopsystem.Data;
using bookshopsystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Repositories
{
    public class ReportRepository : DbContext
    {

        // ===================== GET DAILY SALES =====================
        public List<DailySaleRow> GetDailySales(DateTime date)
        {
            var list = new List<DailySaleRow>();

            string sql = @"
                SELECT s.SaleId, s.SaleDate, st.FullName, s.TotalAmount
                FROM Sales s
                JOIN Staffs st ON s.StaffId = st.StaffId
                WHERE CAST(s.SaleDate AS DATE) = @date
                ORDER BY s.SaleDate DESC";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);

                Connection.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DailySaleRow
                        {
                            SaleId = (int)r["SaleId"],
                            SaleDate = (DateTime)r["SaleDate"],
                            StaffName = r["FullName"].ToString(),
                            TotalAmount = (decimal)r["TotalAmount"]
                        });
                    }
                }
                Connection.Close();
            }

            return list;
        }

        // ===================== GET MONTHLY SALES =====================
        public List<DailySaleRow> GetMonthlySales(int year, int month)
        {
            var list = new List<DailySaleRow>();

            string sql = @"
        SELECT s.SaleId, s.SaleDate, st.FullName, s.TotalAmount
        FROM Sales s
        JOIN Staffs st ON s.StaffId = st.StaffId
        WHERE YEAR(s.SaleDate) = @year AND MONTH(s.SaleDate) = @month
        ORDER BY s.SaleDate DESC";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);

                Connection.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DailySaleRow
                        {
                            SaleId = (int)r["SaleId"],
                            SaleDate = (DateTime)r["SaleDate"],
                            StaffName = r["FullName"].ToString(),
                            TotalAmount = (decimal)r["TotalAmount"]
                        });
                    }
                }
                Connection.Close();
            }

            return list;
        }


        // ===================== GET YEARLY SALES =====================
        public List<DailySaleRow> GetYearlySales(int year)
        {
            var list = new List<DailySaleRow>();

            string sql = @"
        SELECT s.SaleId, s.SaleDate, st.FullName, s.TotalAmount
        FROM Sales s
        JOIN Staffs st ON s.StaffId = st.StaffId
        WHERE YEAR(s.SaleDate) = @year
        ORDER BY s.SaleDate DESC";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@year", year);

                Connection.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DailySaleRow
                        {
                            SaleId = (int)r["SaleId"],
                            SaleDate = (DateTime)r["SaleDate"],
                            StaffName = r["FullName"].ToString(),
                            TotalAmount = (decimal)r["TotalAmount"]
                        });
                    }
                }
                Connection.Close();
            }

            return list;
        }


        // ===================== GET SALES BY RANGE =====================
        public List<DailySaleRow> GetSalesByRange(DateTime from, DateTime to)
        {
            var list = new List<DailySaleRow>();

            string sql = @"
        SELECT s.SaleId, s.SaleDate, st.FullName, s.TotalAmount
        FROM Sales s
        JOIN Staffs st ON s.StaffId = st.StaffId
        WHERE s.SaleDate BETWEEN @from AND @to
        ORDER BY s.SaleDate DESC";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@from", from.Date);
                cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1).AddSeconds(-1));

                Connection.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DailySaleRow
                        {
                            SaleId = (int)r["SaleId"],
                            SaleDate = (DateTime)r["SaleDate"],
                            StaffName = r["FullName"].ToString(),
                            TotalAmount = (decimal)r["TotalAmount"]
                        });
                    }
                }
                Connection.Close();
            }

            return list;
        }

    }
}
