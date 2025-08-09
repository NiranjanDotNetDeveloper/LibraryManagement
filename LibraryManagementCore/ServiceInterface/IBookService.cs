using LibraryCore.Domain.Entity;
using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceInterface
{
    public interface IBookService
    {
        List<BookResponseDTO> GetAllBooks();
        BookResponseDTO AddNewBook(BookRequestDTO bookRequest);
        BookResponseDTO UpdateExistingBook(int id, BookRequestDTO bookRequest);
        bool RemoveBook(int bookId);
        BookResponseDTO FindBookByAuthor(string author);
        BookResponseDTO FindBookByTitle(string title);
    }
}
