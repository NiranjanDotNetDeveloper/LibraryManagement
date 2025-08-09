using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class BookResponseDTO
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int? CopiesAvailable { get; set; }
        public int? Price { get; set; }
    }
    public static class ConvertBookResponseEntity
    {
        public static BookResponseDTO ConvertBookResponseDTOToBook(this Book bookResponse)
        {
            BookResponseDTO book = new BookResponseDTO();
            book.Title = bookResponse.Title;
            book.ISBN = bookResponse.ISBN;
            book.Author = bookResponse.Author;
            book.Price = bookResponse.Price;
            book.CopiesAvailable = bookResponse.CopiesAvailable;
            return book;
        }

    }
}
