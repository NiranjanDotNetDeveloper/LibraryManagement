using LibraryCore.Domain.Entity;
using LibraryInfra.SqlConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContextImpl _dbContext;
        public BookRepository(DbContextImpl dbContext)
        {
            _dbContext = dbContext;
        }
        public Book AddNewBook(Book bookRequest)
        {
                Book book = new Book();
                book.Title = bookRequest.Title;
                book.ISBN = bookRequest.ISBN;
                book.Author = bookRequest.Author;
                book.Price = bookRequest.Price;
                book.CopiesAvailable = bookRequest.CopiesAvailable;
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                return book;

        }

        public Book FindBookByAuthor(string author)
        {
            Book book = _dbContext.Books.FirstOrDefault(x => x.Author == author);
            return book;
        }

        public Book FindBookByTitle(string title)
        {
            Book book = _dbContext.Books.FirstOrDefault(x => x.Title == title);
            return book;
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public bool RemoveBook(int bookId)
        {
            Book book=_dbContext.Books.FirstOrDefault(x => x.BookId == bookId);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
                return true;
            }
            else
                return false;
            
        }

        public Book UpdateExistingBook(int bookId,Book bookRequest)
        {
            Book book = _dbContext.Books.FirstOrDefault(x => x.BookId == bookId);
            book.Title = bookRequest.Title;
            book.ISBN = bookRequest.ISBN;
            book.Author = bookRequest.Author;
            book.Price = bookRequest.Price;
            book.CopiesAvailable = bookRequest.CopiesAvailable;
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
            return book;
        }
    }
}
