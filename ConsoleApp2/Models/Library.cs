using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Library : ILibrary
    {
        private LibraryContext db;

        public Library(LibraryContext _libraryContext)
        {
            this.db = _libraryContext;
        }
       

        public bool Delete(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public Book GetBookById(int bookId)
        {

            return db.Books.Find(bookId);

        }

        public Book getbookbyname(string bookname)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Book book)
        {
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int bookId, Book book)
        {
            Book oldBook = GetBookById(bookId);

            oldBook.BookName = book.BookName;
            oldBook.BookAuthor = book.BookAuthor;
            oldBook.BookTranslator = book.BookTranslator;
            oldBook.BookPublisher = book.BookPublisher;
            oldBook.BookSubjects = book.BookSubjects;
            oldBook.Booklink = book.Booklink;
            oldBook.BookDate = book.BookDate;

            db.SaveChanges();
            return true;
        }


    }
}
