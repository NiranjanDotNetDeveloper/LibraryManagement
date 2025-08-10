using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementUI.Controllers
{
    [Route("[controller]")]
    public class BookController:Controller
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [Route("GetAllBooks")]
        [Route("/")]
        public IActionResult GetAllBooks()
        {
           List<BookResponseDTO> response= bookService.GetAllBooks();
           return View(response);

        }
        [Route("AddNewBooks")]
        [HttpGet]
        public IActionResult AddNewBook()
        {
            BookResponseDTO requestDTO =new BookResponseDTO();
            return View(requestDTO);

        }
        [Route("AddNewBooks")]
        [HttpPost]
        public IActionResult AddNewBook(BookRequestDTO requestDTO)
        {
            BookResponseDTO response = bookService.AddNewBook(requestDTO);
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetAllBooks");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return View(response);
            }

        }
        [Route("UpdateBooks/{title}")]
        [HttpGet]
        public IActionResult UpdateBooks(string title)
        {
            BookResponseDTO requestDTO = bookService.FindBookByTitle(title);
            return View(requestDTO);

        }
        [Route("UpdateBooks/{title}")]
        [HttpPost]
        public IActionResult UpdateBooks(string title,BookRequestDTO requestDTO)
        {
            BookResponseDTO response = bookService.UpdateExistingBook(requestDTO.Title,requestDTO);
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetAllBooks");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return View(response);
            }

        }
        [Route("RemoveBook/{title}")]
        [HttpGet]
        public IActionResult RemoveBooks(string title)
        {
            bool result = bookService.RemoveBook(title);
            if(result)
                return RedirectToAction("GetAllBooks");
            else
                return BadRequest("Book not found or could not be removed.");

        }
    }
}
