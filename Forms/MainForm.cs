using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem
{
    public partial class MainForm : Form
    {
        //private readonly StaffService _staffService;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var passwd = HashPassword(pass.Text.Trim());
            var pass2 = HashPassword(passwd);

            hashPass.Text = passwd;
            hashPass2.Text = pass2;

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
