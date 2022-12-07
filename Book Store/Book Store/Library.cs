using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    public class Library
    {
        List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public Book GetBook(string name)
        {
            return Books.Find(Book => Book.Name.Contains(name));
        }

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public List<Book> FindAllBooks(string name)
        {
           return Books.FindAll(Book => Book.Name.Contains(name)||Book.AuthorName.Contains(name)||Book.PageCount.ToString().Contains(name));
        }

        public void RemoveAllBooks()
        {
            Books.Clear();
        }
    }
}
