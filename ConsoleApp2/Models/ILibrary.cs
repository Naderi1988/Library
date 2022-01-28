using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public interface ILibrary : IDisposable
    {
        bool Insert(Book book);
        bool Update(int bookId, Book book);
        bool Delete(Book book);
        Book GetBookById(int bookId);
        Book getbookbyname(string bookname);
        List<Book> GetAllBooks();
    }
}
