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
            var reponse = bookRepository.FindBookByTitle(title);
            return reponse.ConvertBookResponseDTOToBook();
        }

        public List<BookResponseDTO> GetAllBooks()
        {
            var response = bookRepository.GetAllBooks();
            return response.Select(x => x.ConvertBookResponseDTOToBook()).ToList();
        }

        public bool RemoveBook(string title)
        {
            var reponse = bookRepository.RemoveBook(title);
            return reponse;
        }

        public BookResponseDTO UpdateExistingBook(string title, BookRequestDTO bookRequest)
        {
            var reponse = bookRepository.UpdateExistingBook(title, bookRequest.ConvertBookRequestDTOToBook());
            return reponse.ConvertBookResponseDTOToBook();
        }
    }
}
