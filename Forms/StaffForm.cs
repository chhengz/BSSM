using bookshopsystem.Models;
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

namespace bookshopsystem.Forms
{
    public partial class StaffForm : Form
    {
        private readonly StaffsList _staffslist;
        private readonly StaffService _staffService;
        private readonly int _staffId;


        // ===================== StaffForm Constructor =====================
        public StaffForm( StaffsList staffsList, StaffService staffService, int staffId = 0)
        {
            InitializeComponent();
            lblForm.Text = "Add New Staff";

            _staffslist = staffsList;
            _staffService = staffService;
            _staffId = staffId;

            if (_staffId != 0) LoadStaffForEdit();

            btnUpdate.Visible = _staffId != 0;
            btnSave.Visible = _staffId == 0;

            showPass.Checked = false;
            txtPass.UseSystemPasswordChar = true;
        }

        // ===================== LOAD STAFF FOR EDIT =====================
        private void LoadStaffForEdit()
        {
            var staff = _staffService.GetById(_staffId);
            if (staff == null) return;

            this.Text = "Edit Form | Staff";
            lblForm.Text = $"Edit Staff (ID:{staff.StaffId})";

            txtFullname.Text = staff.FullName;
            txtUser.Text = staff.Username;
            txtUser.Enabled = false; // username should not change
            txtPass.Clear();

            rbAdmin.Checked = staff.Role == "Admin";
            rbStaff.Checked = staff.Role == "Staff";

            chkActive.Checked = staff.IsActive;

            btnUpdate.Visible = true; 
            btnSave.Visible = false;
        }


        // ===================== CLEAR FORM =====================
        private void ClearForm()
        {
            txtFullname.Clear();
            txtUser.Clear();
            txtPass.Clear();
            rbAdmin.Checked = false;
            rbStaff.Checked = false;
            chkActive.Checked = true;
        }

        // ===================== CLOSE BUTTON =====================
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearForm();
            Close();
        }

        // ===================== UPDATE STAFF BUTTON =====================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_staffId == 0)
            {
                MessageBox.Show(
                    "Invalid staff selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string role = GetSelectedRole();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                Staff staff = new Staff
                {
                    StaffId = _staffId,
                    FullName = txtFullname.Text.Trim(),
                    Role = role,
                    IsActive = chkActive.Checked
                };

                // Update password only if provided
                if (!string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    staff.PasswordHash = _staffService.HashPassword(txtPass.Text.Trim());
                    _staffService.UpdateStaffWithPassword(staff);
                }
                else
                {
                    _staffService.UpdateStaff(staff);
                }

                MessageBox.Show(
                    "Staff updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //_staffslist.LoadStaffs(); // refresh list

                _staffslist.LoadPagedStaffs();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ===================== ADD NEW STAFF BUTTON =====================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string fullname, out string username, out string password))
                return;

            string role = GetSelectedRole();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show(
                    "Please select a role (Admin or Staff).",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                Staff staff = new Staff
                {
                    FullName = fullname,
                    Username = username,
                    PasswordHash = _staffService.HashPassword(password),
                    Role = role,
                    IsActive = chkActive.Checked
                };

                _staffService.AddStaff(staff);

                MessageBox.Show(
                    "Staff saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ===================== ROLE SELECTION =====================
        private string GetSelectedRole()
        {
            if (rbAdmin.Checked)  return "Admin";
            if (rbStaff.Checked) return "Staff";
            return null;
        }

        // ===================== SHOW PASSWD BUTTON =====================
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            showPass.Text = showPass.Checked ? "Hide Password" : "Show Password";
            //MessageBox.Show($"{!showPass.Checked}");
            txtPass.UseSystemPasswordChar = !showPass.Checked;
        }

        // ===================== Validate Function =====================
        private bool ValidateInput(out string fname, out string uname, out string pass)
        {
            fname = txtFullname.Text.Trim();
            uname = txtUser.Text.Trim();
            pass = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show(
                    "Username and Password are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (string.IsNullOrWhiteSpace(fname))
            {
                MessageBox.Show(
                    "Full Name is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }



            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            Close();
        }
    }
}
