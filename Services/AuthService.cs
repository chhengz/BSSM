using bookshopsystem.Models;
using bookshopsystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Services
{
    public class AuthService
    {
        private readonly StaffRepository _staffRepo;

        public AuthService()
        {
            _staffRepo = new StaffRepository();
        }

        public Staff Login(string username, string password)
        {
            var staff = _staffRepo.GetByUsername(username);

            if (staff == null) return null;
            if (!staff.IsActive) return null;

            // hash input password before compare
            string hashedInput = HashPassword(password);

            // simple version (hash later if needed)
            //if (staff.PasswordHash != password) return null;

            if (staff.PasswordHash != hashedInput) return null;

            return staff;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

    }
}
