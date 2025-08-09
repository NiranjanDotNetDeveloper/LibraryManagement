using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceImpl
{
    public class BookService : IBookService
    {
        public BookResponseDTO AddNewBook(BookRequestDTO bookRequest)
        {
            throw new NotImplementedException();
        }

        public BookResponseDTO FindBookByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public BookResponseDTO FindBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<BookResponseDTO> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public BookResponseDTO UpdateExistingBook(BookRequestDTO bookRequest)
        {
            throw new NotImplementedException();
        }
    }
}
