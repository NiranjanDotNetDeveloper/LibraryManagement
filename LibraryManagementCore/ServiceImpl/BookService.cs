using LibraryInfra.RepositoryImpl;
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
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }
        public BookResponseDTO AddNewBook(BookRequestDTO bookRequest)
        {
             var reponse= bookRepository.AddNewBook(bookRequest.ConvertBookRequestDTOToBook());
            return reponse.ConvertBookResponseDTOToBook();
        }

        public BookResponseDTO FindBookByAuthor(string author)
        {
            var reponse = bookRepository.FindBookByAuthor(author);
            return reponse.ConvertBookResponseDTOToBook();
        }

        public BookResponseDTO FindBookByTitle(string title)
        {
            var reponse = bookRepository.FindBookByAuthor(title);
            return reponse.ConvertBookResponseDTOToBook();
        }

        public List<BookResponseDTO> GetAllBooks()
        {
            var response = bookRepository.GetAllBooks();
            return response.Select(x => x.ConvertBookResponseDTOToBook()).ToList();
        }

        public bool RemoveBook(int bookId)
        {
            var reponse = bookRepository.RemoveBook(bookId);
            return reponse;
        }

        public BookResponseDTO UpdateExistingBook(int id, BookRequestDTO bookRequest)
        {
            var reponse = bookRepository.UpdateExistingBook(id, bookRequest.ConvertBookRequestDTOToBook());
            return reponse.ConvertBookResponseDTOToBook();
        }
    }
}
