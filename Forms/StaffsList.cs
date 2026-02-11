using bookshopsystem.Models;
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
    public partial class StaffsList : Form
    {
        private readonly StaffService _staffService;
        private const string COL_STAFF_ID = "colStaffId";
        private const string COL_EDIT = "btnEdit";
        private const string COL_DELETE = "btnDelete";

        private int _currentPage = 1;
        private int _pageSize = 10;
        private int _totalStaffs;

        // ===================== StaffsList Constructor =====================
        public StaffsList()
        {
            InitializeComponent();
            _staffService = new StaffService();
            ConfigureGrid();
            //LoadStaffs();

        }

        // ===================== FORM LOAD =====================
        private void StaffsList_Load(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadPagedStaffs();
        }
        // ===================== PAGINATION CONTROLS =====================
        private void UpdatePaginationControls()
        {
            int totalPages = (int)Math.Ceiling((double)_totalStaffs / _pageSize);
            lblPage.Text = $"Page {_currentPage}/{totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
        }

        public void LoadPagedStaffs()
        {
            _totalStaffs = _staffService.GetTotalStaffs();
            LoadStaffs();
            UpdatePaginationControls();
        }

        // ===================== LOAD STAFFS =====================
        public void LoadStaffs(List<Staff> staffs = null)
        {
            try
            {
                dgvStaffs.Rows.Clear();

                if (staffs == null)
                {
                    _totalStaffs = _staffService.GetTotalStaffs();
                    staffs = _staffService.GetPagedStaffs(_currentPage, _pageSize);
                }

                int rowNumber = (_currentPage - 1) * _pageSize + 1;

                foreach (var staff in staffs)
                {
                    string masked = string.IsNullOrEmpty(staff.PasswordHash)
                        ? ""
                        : staff.PasswordHash.Length > 10
                            ? staff.PasswordHash.Substring(0, 10) + "..."
                            : staff.PasswordHash;

                    dgvStaffs.Rows.Add(
                        rowNumber++,
                        staff.StaffId,
                        staff.FullName,
                        staff.Username,
                        masked,
                        staff.Role,
                        staff.IsActive ? "Active" : "Inactive"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staffs: " + ex.Message);
            }
        }

        // ===================== SQL CHANGE EVENT =====================
        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (InvokeRequired)
                dgvStaffs.BeginInvoke(new MethodInvoker(LoadPagedStaffs));
            else
                LoadPagedStaffs();
        }

        // ===================== CONFIGURE DATAGRIDVIEW =====================
        private void ConfigureGrid()
        {
            dgvStaffs.AutoGenerateColumns = false;
            dgvStaffs.ReadOnly = true;
            dgvStaffs.MultiSelect = false;
            dgvStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.AllowUserToAddRows = false;
            dgvStaffs.AllowUserToDeleteRows = false;

        }

        // ===================== CELL CONTENT CLICK (EDIT/DELETE) =====================
        private void dgvStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvStaffs.Rows[e.RowIndex];

            if (!(row.Cells[COL_STAFF_ID].Value is int staffId))
            {
                MessageBox.Show("Invalid staff selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string columnName = dgvStaffs.Columns[e.ColumnIndex].Name;

            if (columnName == COL_EDIT)
            {
                using (var form = new StaffForm(this, _staffService, staffId))
                {
                    form.ShowDialog();
                }
            }
            else if (columnName == COL_DELETE)
            {
                var result = MessageBox.Show(
                    "Delete this staff permanently?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _staffService.DeleteStaff(staffId);
                        _currentPage = 1;
                        LoadStaffs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Delete failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ===================== Add New BUTTON =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new StaffForm(this, _staffService))
            {
                form.ShowDialog();
            }
        }

        // ===================== Next BUTTON =====================
        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalStaffs / _pageSize);

            if (_currentPage < totalPages)
            {
                _currentPage++;
                LoadStaffs();
            }
        }

        // ===================== Prev BUTTON =====================
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadStaffs();
            }
        }

        // ===================== Search BUTTON =====================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                _currentPage = 1;
                LoadStaffs();
                return;
            }

            var staffs = _staffService.SearchStaffs(keyword);
            LoadStaffs(staffs);
        }

        // ===================== Reload BUTTON =====================
        private void btnReload_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            txtSearch.Clear();
            LoadStaffs();
        }

        // -------------------------
    }
}
