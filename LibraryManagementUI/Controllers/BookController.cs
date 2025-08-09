using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementUI.Controllers
{
    public class BookController:Controller
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [Route("/")]
        public IActionResult GetAllBooks()
        {
           List<BookResponseDTO> response= bookService.GetAllBooks();
           return View(response);

        }
    }
}
