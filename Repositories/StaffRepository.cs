using bookshopsystem.Core.Interfaces;
using bookshopsystem.Data;
using bookshopsystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bookshopsystem.Repositories
{
    public class StaffRepository : DbContext, IRepository<Staff>
    {
        public List<Staff> GetAll()
        {
            List<Staff> staffs = new List<Staff>();
            string sql = "SELECT * FROM Staffs";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                staffs.Add(new Staff
                {
                    StaffId = (int)reader["StaffId"],
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Role = reader["Role"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                });
            }

            reader.Close();
            Connection.Close();
            return staffs;
        }

        public Staff GetByUsername(string username)
        {
            string sql = "SELECT * FROM Staffs WHERE Username=@username";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@username", username);

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Staff staff = null;
            if (reader.Read())
            {
                staff = new Staff
                {
                    StaffId = (int)reader["StaffId"],
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Role = reader["Role"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                };
            }

            reader.Close();
            Connection.Close();
            return staff;
        }

        public Staff GetById(int id)
        {
            string sql = "SELECT * FROM Staffs WHERE StaffId=@id";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Staff staff = null;
            if (reader.Read())
            {
                staff = new Staff
                {
                    StaffId = (int)reader["StaffId"],
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Role = reader["Role"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                };
            }

            reader.Close();
            Connection.Close();
            return staff;
        }

        public List<Staff> GetPaged(int page, int pageSize)
        {
            List<Staff> staffs = new List<Staff>();

            string sql = @"SELECT * FROM Staffs
                   ORDER BY StaffId
                   OFFSET @offset ROWS
                   FETCH NEXT @size ROWS ONLY";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
            cmd.Parameters.AddWithValue("@size", pageSize);

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                staffs.Add(new Staff
                {
                    StaffId = (int)reader["StaffId"],
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Role = reader["Role"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                });
            }

            reader.Close();
            Connection.Close();

            return staffs;
        }

        public int GetTotalCount()
        {
            string sql = "SELECT COUNT(*) FROM Staffs";

            SqlCommand cmd = new SqlCommand(sql, Connection);

            Connection.Open();
            int total = (int)cmd.ExecuteScalar();
            Connection.Close();

            return total;
        }


        public List<Staff> Search(string keyword)
        {
            List<Staff> staffs = new List<Staff>();

            string sql = @"SELECT * FROM Staffs
                   WHERE Username LIKE @kw
                   OR FullName LIKE @kw
                   OR Role LIKE @kw";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                staffs.Add(new Staff
                {
                    StaffId = (int)reader["StaffId"],
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Role = reader["Role"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                });
            }

            reader.Close();
            Connection.Close();

            return staffs;
        }




        public void Add(Staff staff)
        {
            string sql = @"INSERT INTO Staffs
                           (Username, PasswordHash, FullName, Role, IsActive)
                           VALUES (@u,@p,@f,@r,@a)";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@u", staff.Username);
            cmd.Parameters.AddWithValue("@p", staff.PasswordHash);
            cmd.Parameters.AddWithValue("@f", staff.FullName);
            cmd.Parameters.AddWithValue("@r", staff.Role);
            cmd.Parameters.AddWithValue("@a", staff.IsActive);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        


        public void Update(Staff staff)
        {
            string sql = @"UPDATE Staffs SET
                           FullName=@f,
                           Role=@r,
                           IsActive=@a
                           WHERE StaffId=@id";

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@f", staff.FullName);
            cmd.Parameters.AddWithValue("@r", staff.Role);
            cmd.Parameters.AddWithValue("@a", staff.IsActive);
            cmd.Parameters.AddWithValue("@id", staff.StaffId);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Staffs WHERE StaffId=@id";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@id", id);

            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateWithPassword(Staff staff)
        {
            string sql = @"UPDATE Staffs SET
                   PasswordHash=@p,
                   Role=@r,
                   IsActive=@a
                   WHERE StaffId=@id";

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@p", staff.PasswordHash);
                cmd.Parameters.AddWithValue("@r", staff.Role);
                cmd.Parameters.AddWithValue("@a", staff.IsActive);
                cmd.Parameters.AddWithValue("@id", staff.StaffId);

                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
        }


    }
}
