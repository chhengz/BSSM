using bookshopsystem.Core.Patterns;
using bookshopsystem.Models;
using bookshopsystem.Repositories;
using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class POSForm : Form
    {
        private Staff _currentStaff;
        private readonly BookServices _bookService;
        private readonly Dictionary<int, OrderItem> orderItems = new Dictionary<int, OrderItem>();
        private List<Book> _allBooks = new List<Book>();
        private decimal totalPay = 0;

        private int _currentPage = 1;
        private int _pageSize = 10;
        private int _totalBooks;

        // ===================== POSForm Constructor =====================
        public POSForm(Staff staff, BookServices bookService)
        {
            InitializeComponent();
            this.SuspendLayout();
            this.WindowState = FormWindowState.Maximized;
            _currentStaff = staff;
            _bookService = bookService;

            this.Text = $"BookShop POS ({_currentStaff.Username})";
            SetupFlowLayoutPanel();
            this.ResumeLayout();
        }

        // ===================== FORM LOAD =====================
        private void POSForm_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = _currentStaff.FullName;
            LoadPagedBooks();
            RefreshCheckoutItems();
            StartClock();
        }

        // ===================== LOAD PAGED BOOKS =====================
        private void LoadPagedBooks()
        {
            _totalBooks = _bookService.GetTotalBooks();

            var books = _bookService.GetPagedBooks(_currentPage, _pageSize);

            LoadBooksIntoCards(books);
            UpdatePaginationControls();
        }

        // ===================== UPDATE PAGINATION CONTROLS =====================
        private void UpdatePaginationControls()
        {
            int totalPages = (int)Math.Ceiling((double)_totalBooks / _pageSize);
            lblPage.Text = $"Page {_currentPage}/{totalPages}";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
        }

        // ===================== CONFIGURE FLOWLAYOUT =====================
        private void SetupFlowLayoutPanel()
        {
            flowLayout_Panel.AutoScroll = true;
            flowLayout_Panel.WrapContents = true;
            flowLayout_Panel.FlowDirection = FlowDirection.LeftToRight;

            if (itemlistFlowlayout_panel != null)
            {
                itemlistFlowlayout_panel.AutoScroll = true;
                itemlistFlowlayout_panel.WrapContents = false;
                itemlistFlowlayout_panel.FlowDirection = FlowDirection.TopDown;
            }
        }

        // ===================== LOAD BOOK INTO CARD =====================
        private void LoadBooksIntoCards(List<Book> books = null)
        {
            flowLayout_Panel.Controls.Clear();

            if (_bookService == null)
            {
                MessageBox.Show("BookService is NULL");
                return;
            }

            if (books == null)
                books = _allBooks;

            if (books == null || books.Count == 0)
            {
                MessageBox.Show("No books available.", "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            foreach (var book in books)
            {
                var card = new ucBookCard(book);
                card.OnAddToCart += Card_OnAddToCart;
                flowLayout_Panel.Controls.Add(card);
            }
        }

        // ===================== ADD TO CARD =====================
        private void Card_OnAddToCart(object sender, Book book)
        {
            if (book == null) return;

            int id = book.BookId;

            if (!orderItems.ContainsKey(id))
            {
                var newItem = new OrderItem
                {
                    Book = book,
                    Quantity = 1
                };
                orderItems[id] = newItem;
            }
            else
            {
                var existing = orderItems[id];
                if (existing.Quantity + 1 > book.Stock)
                {
                    MessageBox.Show($"Only {book.Stock} in stock!", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existing.Quantity++;
            }

            RefreshCheckoutItems();
        }

        // ===================== Refresh Checkout =====================
        private void RefreshCheckoutItems()
        {
            if (itemlistFlowlayout_panel == null) return;

            itemlistFlowlayout_panel.Controls.Clear();
            decimal grandTotal = 0;

            foreach (var kv in orderItems)
            {
                var orderItem = kv.Value;
                // Subtotal is computed by OrderItem.Subtotal getter
                var itemCard = new ucItemCard(orderItem);
                itemCard.QuantityChanged += ItemCard_QuantityChanged;
                itemCard.RemoveRequested += ItemCard_RemoveRequested;

                itemlistFlowlayout_panel.Controls.Add(itemCard);

                grandTotal += orderItem.Subtotal;
            }

            //lblTotal.Text = $"${grandTotal:N0}"; // with thousand separators
            lblTotal.Text = $"${grandTotal}";
            totalPay = grandTotal;

        }

        // ===================== ITEM CARD EVENTS =====================
        private void ItemCard_QuantityChanged(object sender, EventArgs e)
        {
            var uc = sender as ucItemCard;
            if (uc == null) return;

            var item = uc.Item;
            if (item == null) return;

            if (orderItems.ContainsKey(item.Book.BookId))
            {
                orderItems[item.Book.BookId].Quantity = item.Quantity;
            }

            RefreshCheckoutItems();
        }

        // ===================== ITEM CARD EVENTS =====================
        private void ItemCard_RemoveRequested(object sender, EventArgs e)
        {
            var uc = sender as ucItemCard;
            if (uc == null) return;

            var item = uc.Item;
            if (item == null) return;

            if (orderItems.ContainsKey(item.Book.BookId))
                orderItems.Remove(item.Book.BookId);

            RefreshCheckoutItems();
        }

        // ===================== REFRESH BOOKS =====================
        public void RefreshBooks() => LoadBooksIntoCards();

        // ===================== EXIT BUTTON =====================
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
        
        // ===================== CHECKOUT BUTTON =====================
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Proceed to payment of ${totalPay:N2}?",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                var saleService = new SaleService();
                int saleId = saleService.Checkout(
                    _currentStaff.StaffId,
                    orderItems.Values
                );

                // show qr code
                var qrForm = new QRPayForm(totalPay.ToString());
                qrForm.ShowDialog(this);

                MessageBox.Show(
                    $"Checkout completed!\nSale ID: {saleId}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                orderItems.Clear();
                RefreshCheckoutItems();

                //_allBooks = _bookService.GetAllBooks();
                //LoadBooksIntoCards(_allBooks);
                LoadPagedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Checkout failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ===================== FashCash BUTTON =====================
        private void btnFashCash_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "Fast Cash",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var saleService = new SaleService();

                int saleId = saleService.Checkout(
                    _currentStaff.StaffId,
                    orderItems.Values
                );

                // ----------------------------------------------
                
                var receipt = BuildReceipt(saleId);
                var receiptForm = new ReceiptForm(receipt);
                receiptForm.ShowDialog(this);

                // ----------------------------------------------

                orderItems.Clear();
                RefreshCheckoutItems();

                //_allBooks = _bookService.GetAllBooks();
                //LoadBooksIntoCards(_allBooks);
                LoadPagedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Fast cash failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ===================== Build Receipt =====================
        private Receipt BuildReceipt(int saleId)
        {
            var receipt = ReceiptFactory.Create(saleId);

            foreach (var item in orderItems.Values)
            {
                receipt.Items.Add(new ReceiptItem
                {
                    Title = item.Book.Title,
                    Quantity = item.Quantity,
                    Price = item.Book.Price
                });

                receipt.Total += item.Subtotal;
            }

            return receipt;
        }

        // ===================== SEARCH BUTTON =====================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadBooksIntoCards(_allBooks);
                return;
            }

            var filteredBooks = _allBooks.Where(b =>
                b.ISBN.ToLower().Contains(keyword) ||
                b.Title.ToLower().Contains(keyword) ||
                b.Author.ToLower().Contains(keyword)
            ).ToList();

            LoadBooksIntoCards(filteredBooks);

        }

        // ===================== CLOCK =====================
        private void StartClock()
        {
            Timer timer = new Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                lblDateTime.Text =
                    DateTime.Now.ToString("hh:mm tt") + "\n" +
                    DateTime.Now.ToString("MM/dd/yyyy");
            };
            timer.Start();
        }

        // ===================== PREV BUTTON =====================
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadPagedBooks();
            }
        }
        // ===================== NEXT BUTTON =====================
        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalBooks / _pageSize);

            if (_currentPage < totalPages)
            {
                _currentPage++;
                LoadPagedBooks();
            }
        }

        // ===================== RELOAD BUTTON =====================
        private void btnReload_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            txtSearch.Clear();
            LoadPagedBooks();
        }
    }

    // ===================== CART LINE CLASS =====================
    public class CartLine
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}