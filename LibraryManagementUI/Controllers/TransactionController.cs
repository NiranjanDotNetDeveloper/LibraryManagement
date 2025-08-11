using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementUI.Controllers
{
    [Route("[controller]")]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly IBookService _bookService;
        private readonly IMemberService _memberService;
        public TransactionController(ITransactionService transactionService, IBookService bookService, IMemberService memberService)
        {
            _transactionService = transactionService;
            _bookService = bookService;
            _memberService = memberService;
        }
        [Route("GetAllTransaction")]
        public IActionResult GetAllTransaction()
        {
            var response = _transactionService.GetAllTransaction();
            return View(response);
        }
        [Route("AddTransaction")]
        [HttpGet]
        public IActionResult AddTransactions()
        {
            var response = new TransactionRequestDTO();
            //var books= _bookService.GetAllBooks();
            //var members = _memberService.GetAllMembers();
            var transaction = _transactionService.GetAllTransaction();
            var allBookId = transaction.Select(x => x.Books);
            var allMembers = transaction.Select(x => x.Members);
            ViewBag.Book = allBookId.Select(x => new SelectListItem
            {
                Value = x.BookId.ToString(), // dropdown value
                Text = x.Title               // dropdown display text
            }).ToList();
            ViewBag.Member = allMembers.Select(x => new SelectListItem
            {
                Value = x.MemoberId.ToString(),
                Text = x.Name
            }).ToList();
            return View(response);
        }
        [Route("AddTransaction")]
        [HttpPost]
        public IActionResult AddTransactions(TransactionRequestDTO request)
        {
            var response = _transactionService.AddNewTransaction(request);
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Transaction added successfully!";
                return RedirectToAction("GetAllTransaction");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                TempData["ErrorMessage"] = "Failed to add Transaction!";
                return View(response);
            }
        }
    }
}
