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
        Book UpdateExistingBook(string title,Book bookRequest);
        bool RemoveBook(string title);
        Book FindBookByAuthor(string author);
        Book FindBookByTitle(string title);
    }
}
