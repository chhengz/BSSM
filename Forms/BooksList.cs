using bookshopsystem.Models;
using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class BooksList : Form
    {
        private readonly BookServices _bookService;
        private const string COL_BOOK_ID = "colBookId";
        private const string COL_EDIT = "btnEdit";
        private const string COL_DELETE = "btnDelete";

        private int _currentPage = 1;
        private int _pageSize = 10;
        private int _totalBooks;

        // ===================== BooksList Constructor =====================
        public BooksList()
        {
            InitializeComponent();
            _bookService = new BookServices();
            ConfigureGrid();
            //LoadPagedBooks();
        }

        // ===================== FORM LOAD =====================
        private void BooksList_Load(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadPagedBooks();
        }

        private void LoadPagedBooks()
        {
            _totalBooks = _bookService.GetTotalBooks();
            LoadBooks();
            UpdatePaginationControls();
        }

        private void UpdatePaginationControls()
        {
            int totalPages = (int)Math.Ceiling((double)_totalBooks / _pageSize);
            lblPage.Text = $"Page {_currentPage}/{totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
        }

        // ===================== Next BUTTON =====================
        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalBooks / _pageSize);

            if (_currentPage < totalPages)
            {
                _currentPage++;
                LoadPagedBooks();
            }
        }

        // ===================== Prev BUTTON =====================
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadPagedBooks();
            }
        }

        // ===================== SQL CHANGE EVENT =====================
        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (InvokeRequired)
                dgvBooks.BeginInvoke(new MethodInvoker(LoadPagedBooks));
            else
                LoadPagedBooks();
        }

        // ===================== LOAD BOOKS =====================
        public void LoadBooks(List<Book> books = null)
        {
            try
            {
                dgvBooks.Rows.Clear();

                if (books == null)
                    books = _bookService.GetPagedBooks(_currentPage, _pageSize);

                //int rowNumber = 1;
                int rowNumber = (_currentPage - 1) * _pageSize + 1;

                foreach (var book in books)
                {
                    Image img = null;

                    if (!string.IsNullOrEmpty(book.CoverImage))
                    {
                        string fullPath = Path.Combine(
                            Application.StartupPath,
                            book.CoverImage.TrimStart('/')
                        );

                        if (File.Exists(fullPath))
                        {
                            using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            {
                                img = Image.FromStream(fs);
                            }
                        }
                    }

                    dgvBooks.Rows.Add(
                        rowNumber++,
                        img,
                        book.BookId,
                        book.ISBN,
                        book.Title,
                        book.Author,
                        book.Price.ToString("N2"),
                        book.Stock
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books:\n{ex.Message}");
            }
        }

        // ===================== CONFIGURE GRID =====================
        private void ConfigureGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.MultiSelect = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;

        }

        // ===================== ADD BUTTON =====================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new BookForm(this, _bookService))
            {
                form.ShowDialog();
            }
        }

        // ===================== EDIT/DELETE BUTTON =====================
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvBooks.Rows[e.RowIndex];

            if (!(row.Cells[COL_BOOK_ID].Value is int bookId))
            {
                MessageBox.Show("Invalid book selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string columnName = dgvBooks.Columns[e.ColumnIndex].Name;

            if (columnName == COL_EDIT)
            {
                using (var form = new BookForm(this, _bookService, bookId))
                {
                    form.ShowDialog();
                }
            }
            else if (columnName == COL_DELETE)
            {
                var result = MessageBox.Show(
                    "Delete this book permanently?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _bookService.DeleteBook(bookId);
                        LoadBooks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Delete failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ===================== SEARCH BUTTON =====================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                _currentPage = 1;
                LoadBooks();
                return;
            }

            var staffs = _bookService.SearchBooks(keyword);
            LoadBooks(staffs);
        }

        // ===================== RELOAD BUTTON =====================
        private void btnReload_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            txtSearch.Clear();
            LoadPagedBooks();
        }

        // ----------------------------
    }
}
