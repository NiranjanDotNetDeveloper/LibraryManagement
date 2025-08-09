using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class BookRepository : IBookRepository
    {
        public Book AddNewBook(Book bookRequest)
        {
            throw new NotImplementedException();
        }

        public Book FindBookByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public Book FindBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public Book UpdateExistingBook(Book bookRequest)
        {
            throw new NotImplementedException();
        }
    }
}
