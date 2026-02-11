using bookshopsystem.Models;
using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class BookForm : Form
    {
        private readonly BooksList _bookList;
        private readonly BookServices _bookServices;
        private string _selectedImagePath;
        private int _bookId = 0;

        // ===================== BookForm Constructor =====================
        public BookForm(BooksList bookList, BookServices bookServices, int bookId = 0)
        {
            InitializeComponent();
            this.SuspendLayout();
            lblForm.Text = "Add New Book";
            _bookList = bookList;
            _bookServices = bookServices;
            _bookId = bookId;
            btnUpdate.Visible = false;
            if (_bookId > 0)
                LoadBookForEdit();
            
            this.ResumeLayout();
        }

        // ===================== LOAD BOOK FOR EDIT =====================
        private void LoadBookForEdit()
        {
            var book = _bookServices.GetBookById(_bookId);
            this.Text = "Edit Form | Book";
            lblForm.Text = $"Edit Book (ID:{book.BookId})";

            if (book == null) return;

            txtISBN.Text = book.ISBN;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPrice.Text = book.Price.ToString();
            txtStock.Text = book.Stock.ToString();

            _selectedImagePath = book.CoverImage;

            // Load image safely
            if (!string.IsNullOrEmpty(book.CoverImage))
            {
                string imagePath = Path.Combine(Application.StartupPath, book.CoverImage);

                if (File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        picCover.Image = Image.FromStream(fs);
                    }
      
                }
                else
                {
                    picCover.Image = Properties.Resources.no_image;
                }
            }

            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        // ===================== ADD BOOK BUTTON =====================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var isbn, out var title, out var author, out var price, out var stock))
                return;

            var book = new Book
            {
                ISBN = isbn,
                Title = title,
                Author = author,
                Price = price,
                Stock = stock,
                CoverImage = SaveBookImage(_selectedImagePath)
            };

            try
            {
                _bookServices.AddBook(book);
                _bookList.LoadBooks();
                MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                // this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== UPDATE BUTTON =====================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var isbn, out var title, out var author, out var price, out var stock))
                return;

            var book = new Book
            {
                BookId = _bookId,
                ISBN = isbn,
                Title = title,
                Author = author,
                Price = price,
                Stock = stock,
                CoverImage = null 
            };

            string newImageRelativePath = null;

            if (!string.IsNullOrEmpty(_selectedImagePath))
            {
                newImageRelativePath = SaveBookImage(_selectedImagePath);
                var oldBook = _bookServices.GetBookById(_bookId);
                if (oldBook?.CoverImage != null && oldBook.CoverImage != newImageRelativePath)
                {
                    string oldFullPath = Path.Combine(Application.StartupPath, oldBook.CoverImage);
                    if (File.Exists(oldFullPath))
                    {
                        try { File.Delete(oldFullPath); } catch { }
                    }
                }
            }
            else
            {
                var oldBook = _bookServices.GetBookById(_bookId);
                newImageRelativePath = oldBook?.CoverImage;
            }

            book.CoverImage = newImageRelativePath;

            try
            {
                _bookServices.UpdateBook(book);
                _bookList.LoadBooks();
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== CLOSE BUTTON =====================
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }

        // ===================== CLEAR FORM =====================
        private void ClearForm()
        {
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            picCover.Image = null;

            btnSave.Visible = true;
            btnUpdate.Visible = false;

        }
        // ===================== CANCEL BUTTON =====================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }


        // ===================== Validate Function =====================
        private bool ValidateInput(out string isbn, out string title, out string author, out decimal price, out int stock)
        {
            isbn = txtISBN.Text.Trim();
            title = txtTitle.Text.Trim();
            author = txtAuthor.Text.Trim();
            price = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("ISBN, Title, and Author are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price (> 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity (≥ 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        // ===================== ChooseImage BUTTON =====================
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (picCover.Image != null)
                    {
                        picCover.Image.Dispose();
                        picCover.Image = null;
                    }

                    _selectedImagePath = ofd.FileName;
                    picCover.Image = Image.FromFile(_selectedImagePath);
                    picCover.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // ===================== SaveBook Function =====================
        private string SaveBookImage(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
                return null;

            string folder = Path.Combine(Application.StartupPath, "images", "books");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string fileName = Path.GetFileName(sourcePath);
            string destPath = Path.Combine(folder, fileName);

            File.Copy(sourcePath, destPath, true);

            return Path.Combine("images", "books", fileName).Replace("\\", "/");
        }

        // ----------
    }
}
