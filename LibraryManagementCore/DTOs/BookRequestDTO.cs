using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class BookRequestDTO
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        [Required(ErrorMessage = "CopiesAvailable is required")]
        public int? CopiesAvailable { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int? Price { get; set; }
    }
    public static class ConvertBookEntity
    {
        public static Book ConvertBookRequestDTOToBook(this BookRequestDTO bookRequestDTO)
        {
            Book book = new Book();
            book.BookId = bookRequestDTO.BookId;
            book.Title = bookRequestDTO.Title;
            book.ISBN = bookRequestDTO.ISBN;
            book.Author = bookRequestDTO.Author;
            book.Price = bookRequestDTO.Price;
            book.CopiesAvailable = bookRequestDTO.CopiesAvailable;
            return book;
        }

    }
}
