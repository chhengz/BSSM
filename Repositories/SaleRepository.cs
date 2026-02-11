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
    public class SaleRepository : DbContext
    {
        public int CreateSale(Sale sale, List<SaleDetail> details)
        {
            Connection.Open();
            SqlTransaction transaction = Connection.BeginTransaction();

            try
            {
                string saleSql = @"INSERT INTO Sales (StaffId, SaleDate, TotalAmount)
                                   OUTPUT INSERTED.SaleId
                                   VALUES (@staffId, GETDATE(), @total)";

                SqlCommand saleCmd = new SqlCommand(saleSql, Connection, transaction);
                saleCmd.Parameters.AddWithValue("@staffId", sale.StaffId);
                saleCmd.Parameters.AddWithValue("@total", sale.TotalAmount);

                int saleId = (int)saleCmd.ExecuteScalar();

                foreach (var d in details)
                {
                    // Stock check + update
                    string stockSql = @"UPDATE Books
                                        SET Stock = Stock - @qty
                                        WHERE BookId = @bookId AND Stock >= @qty";

                    SqlCommand stockCmd = new SqlCommand(stockSql, Connection, transaction);
                    stockCmd.Parameters.AddWithValue("@qty", d.Quantity);
                    stockCmd.Parameters.AddWithValue("@bookId", d.BookId);

                    if (stockCmd.ExecuteNonQuery() == 0)
                        throw new Exception("Insufficient stock.");

                    string detailSql = @"INSERT INTO SaleDetails
                                         (SaleId, BookId, Quantity, UnitPrice)
                                         VALUES (@saleId, @bookId, @qty, @price)";

                    SqlCommand detailCmd = new SqlCommand(detailSql, Connection, transaction);
                    detailCmd.Parameters.AddWithValue("@saleId", saleId);
                    detailCmd.Parameters.AddWithValue("@bookId", d.BookId);
                    detailCmd.Parameters.AddWithValue("@qty", d.Quantity);
                    detailCmd.Parameters.AddWithValue("@price", d.UnitPrice);

                    detailCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return saleId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
