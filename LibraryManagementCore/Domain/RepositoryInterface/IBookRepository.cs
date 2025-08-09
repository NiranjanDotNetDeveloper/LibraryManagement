using LibraryCore.Domain.Entity;
using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book AddNewBook(Book bookRequest);
        Book UpdateExistingBook(int bookId,Book bookRequest);
        bool RemoveBook(int bookId);
        Book FindBookByAuthor(string author);
        Book FindBookByTitle(string title);
    }
}
