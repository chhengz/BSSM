using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // Admin / Staff
        public bool IsActive { get; set; }
    }
}
