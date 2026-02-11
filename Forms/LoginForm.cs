using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly BookServices _bookService = new BookServices();

        // ===================== LoginForm Constructor =====================
        public LoginForm()
        {
            InitializeComponent();
            this.SuspendLayout();
            bunifuPanel1.Parent = this;
            bunifuPanel1.BackColor = Color.Transparent;
            this.AcceptButton = btnLogin;
            this.ResumeLayout();
        }

        // ===================== LOGIN BUTTON =====================
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var authService = new AuthService();
                //var staff = authService.Login(username, password);
                var staff = await Task.Run(() => authService.Login(username, password));

                if (staff == null)
                {
                    lblError.Text = "Invalid username or password";
                    lblError.Visible = true;

                    MessageBox.Show("Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();

                if (staff.Role == "Admin")
                    new DashboardForm(staff).ShowDialog();
                else
                    new POSForm(staff, _bookService).ShowDialog();

                this.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
                ClearForm();
            }
        }

        // ===================== CLEAR FORM FIELDS =====================
        private void ClearForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblError.Visible = false;
        }

    } 
}
