using bookshopsystem.Models;
using bookshopsystem.Services;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class DashboardForm : Form
    {
        private Staff _currentStaff;
        private Form activeForm;
        private BunifuButton currentButton;
        private readonly BookServices _bookService = new BookServices();

        // ===================== DashboardForm Constructor =====================
        public DashboardForm(Staff staff)
        {
            InitializeComponent();

            //this.KeyPreview = true;
            //this.KeyDown += DashboardForm_KeyDown;

            this.SuspendLayout();
            this.Text = "Book Shop | Dashboard";
            this.WindowState = FormWindowState.Maximized;
            bunifuPanel3.Parent = sidebar_panel;
            bunifuPanel3.BackColor = Color.Transparent;

            _currentStaff = staff;
            lblStaffName.Text = _currentStaff.FullName;
            StartClock();
            this.ResumeLayout();
        }

        // ===================== KeyDown Event Handler =====================
        //private void DashboardForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        if (this.WindowState == FormWindowState.Maximized)
        //        {
        //            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        //            this.WindowState = FormWindowState.Normal;
        //        }
        //    }
        //    else if (e.KeyCode == Keys.F11)
        //    {
        //        this.FormBorderStyle = FormBorderStyle.None;
        //        this.WindowState = FormWindowState.Maximized;
        //    }
        //}

        // ===================== StartClock =====================
        private void StartClock()
        {
            Timer timer = new Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                lblDateTime.Text =
                    DateTime.Now.ToString("hh:mm tt") + " " + DateTime.Now.ToString("MM/dd/yyyy");
            };
            timer.Start();
        }

        // ===================== Navigation Button Clicks =====================
        private void btnBookForm_Click(object sender, EventArgs e)
            => OpenChildForm(new BooksList(), sender);

        private void btnSaleForm_Click(object sender, EventArgs e)
            => OpenChildForm(new ReportsForm(), sender);

        private void btnStaffForm_Click(object sender, EventArgs e)
            => OpenChildForm(new StaffsList(), sender);

        // ===================== Helper Methods =====================
        private void OpenChildForm(Form childForm, object sender)
        {
            activeForm?.Close();
            ActivateButton(sender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoScroll = true;
            childForm.Dock = DockStyle.Fill;

            mainForm_panel.Controls.Clear();
            mainForm_panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            //lblTitle.Text = childForm.Text;
            //CenterTitle();
        }

        private void ActivateButton(object sender)
        {
            if (!(sender is BunifuButton btn))
                return;

            if (btn == currentButton)
                return;

            ResetButtonStyles();
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(24, 56, 47);
        }

        private void ResetButtonStyles()
        {
            foreach (Control control in sidebar_panel.Controls)
            {
                if (control is BunifuButton btn)
                {
                    btn.BackColor = Color.Transparent;
                }
            }
        }

        // ===================== Exit Button Click =====================
        private void picBtnExit_Click(object sender, EventArgs e)
        {
            DialogResult re = DialogResult.Yes;
            re = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // -------------------------
    }
}
