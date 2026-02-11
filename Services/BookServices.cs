using bookshopsystem.Models;
using bookshopsystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshopsystem.Services
{
    public class BookServices
    {
        //private readonly StaffRepository _repo;
        private readonly BookRepository _repo;
        public BookServices()
        {
            _repo = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        public Book GetBookById(int id) {
            return _repo.GetById(id);
        }

        public List<Book> GetPagedBooks(int page, int pageSize)
        {
            return _repo.GetPaged(page, pageSize);
        }

        public int GetTotalBooks()
        {
            return _repo.GetTotalCount();
        }


        public List<Book> SearchBooks(string keyword)
        {
            return _repo.Search(keyword);
        }


        public void AddBook(Book book) {
            _repo.Add(book);
        }

        public void UpdateBook(Book book) {
            _repo.Update(book);
        }

        public void DeleteBook(int id)
        {
            _repo.Delete(id);
        }
    }
}
