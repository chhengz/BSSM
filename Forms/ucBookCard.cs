using bookshopsystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{

    public partial class ucBookCard : UserControl
    {

        public Book _book;

        public event EventHandler<Book> OnAddToCart;

        public ucBookCard(Book book)
        {
            InitializeComponent();
            _book = book ?? throw new ArgumentNullException(nameof(book));

            this.Cursor = Cursors.Hand;
            this.TabStop = true;
            this.Click += (s, e) => this.Focus();

            picBookCover.Parent = pic_panel;

            LoadData();
            EnableClick(this);
        }

        private void LoadData()
        {
            lblTitle.Text = _book.Title;
            lblPrice.Text = $"${_book.Price:N2}";

            if (_book.Stock > 0)
            {
                lblStock.Text = $"Stock: {_book.Stock}";
                //lblStock.ForeColor = Color.DimGray;
            }
            else
            {
                lblStock.Text = "Out of Stock";
                lblStock.ForeColor = Color.IndianRed;
                this.Enabled = false;
            }

            LoadCoverImage();

        }

        
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (_book.Stock <= 0) return;

            OnAddToCart?.Invoke(this, _book);
        }

        

        private void EnableClick(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);

                if (c.HasChildren)
                    EnableClick(c);
            }
        }

        private void LoadCoverImage()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_book.CoverImage))
                {
                    picBookCover.Image = Properties.Resources.no_image;
                    return;
                }

                // Assuming CoverImage is stored as relative path: "images/books/xyz.jpg"
                string fullPath = Path.Combine(Application.StartupPath, _book.CoverImage);

                if (File.Exists(fullPath))
                {
                    // Important: use using or dispose previous
                    if (picBookCover.Image != null)
                    {
                        picBookCover.Image.Dispose();
                        picBookCover.Image = null;
                    }

                    using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        picBookCover.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    picBookCover.Image = Properties.Resources.no_image;
                }

                //picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                picBookCover.Image = Properties.Resources.no_image;
            }
        }


    }
}

