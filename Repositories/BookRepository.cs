using bookshopsystem.Core.Interfaces;
using bookshopsystem.Data;
using bookshopsystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Repositories
{
    public class BookRepository : DbContext, IRepository<Book>
    {
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            string sql = "SELECT * FROM Books";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book
                {
                    BookId = (int)reader["BookId"],
                    ISBN = reader["ISBN"].ToString(),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Price = (decimal)reader["Price"],
                    Stock = (int)reader["Stock"],
                    CreatedAt = (DateTime)reader["CreatedAt"],
                    CoverImage = reader["CoverImage"] == DBNull.Value
                             ? null
                             : reader["CoverImage"].ToString()
                });
            }

            reader.Close();
            Connection.Close();

            return books;
        }

        

        public Book GetById(int id)
        {
            string sql = "SELECT * FROM Books WHERE BookId=@id";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Book book = null;
            if (reader.Read())
            {
                book = new Book
                {
                    BookId = (int)reader["BookId"],
                    ISBN = reader["ISBN"].ToString(),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Price = (decimal)reader["Price"],
                    Stock = (int)reader["Stock"],
                    CreatedAt = (DateTime)reader["CreatedAt"],
                    CoverImage = reader["CoverImage"] == DBNull.Value
                             ? null
                             : reader["CoverImage"].ToString(),
                };
            }

            reader.Close();
            Connection.Close();
            return book;
        }


        public List<Book> GetPaged(int page, int pageSize)
        {
            List<Book> books = new List<Book>();

            string sql = @"SELECT * FROM Books
                   ORDER BY BookId
                   OFFSET @offset ROWS
                   FETCH NEXT @pageSize ROWS ONLY";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
            cmd.Parameters.AddWithValue("@pageSize", pageSize);

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book
                {
                    BookId = (int)reader["BookId"],
                    ISBN = reader["ISBN"].ToString(),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Price = (decimal)reader["Price"],
                    Stock = (int)reader["Stock"],
                    CreatedAt = (DateTime)reader["CreatedAt"],
                    CoverImage = reader["CoverImage"] == DBNull.Value
                                ? null
                                : reader["CoverImage"].ToString()
                });
            }

            reader.Close();
            Connection.Close();

            return books;
        }


        public int GetTotalCount()
        {
            string sql = "SELECT COUNT(*) FROM Books";

            SqlCommand cmd = new SqlCommand(sql, Connection);

            Connection.Open();
            int total = (int)cmd.ExecuteScalar();
            Connection.Close();

            return total;
        }


        public List<Book> Search(string keyword)
        {
            List<Book> books = new List<Book>();

            string sql = @"SELECT * FROM Books
                   WHERE Title LIKE @kw
                   OR Author LIKE @kw
                   OR ISBN LIKE @kw";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book
                {
                    BookId = (int)reader["BookId"],
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    ISBN = reader["ISBN"].ToString(),
                    Price = (decimal)reader["Price"],
                    Stock = (int)reader["Stock"],
                    CoverImage = reader["CoverImage"] == DBNull.Value
                                ? null
                                : reader["CoverImage"].ToString()
                });
            }

            reader.Close();
            Connection.Close();

            return books;
        }





        public void Add(Book book)
        {
            string sql = @"INSERT INTO Books
                        (ISBN, Title, Author, Price, Stock, CoverImage, CreatedAt)
                        VALUES (@isbn, @title, @author, @price, @stock, @cover, GETDATE())";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@isbn", book.ISBN);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@price", book.Price);
            cmd.Parameters.AddWithValue("@stock", book.Stock);
            cmd.Parameters.AddWithValue("@cover",
                (object)book.CoverImage ?? DBNull.Value);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public void Update(Book book)
        {
            string sql = @"UPDATE Books SET
                           ISBN=@isbn,
                           Title=@title,
                           Author=@author,
                           Price=@price,
                           Stock=@stock,
                           CoverImage=@cover
                           WHERE BookId=@id";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@isbn", book.ISBN);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@price", book.Price);
            cmd.Parameters.AddWithValue("@stock", book.Stock);
            cmd.Parameters.AddWithValue("@id", book.BookId);
            cmd.Parameters.AddWithValue("@cover",
                (object)book.CoverImage ?? DBNull.Value);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Books WHERE BookId=@id";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
