using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementUI.Controllers
{
    public class HomeController : Controller
    {
        // This controller handles the home page of the Library Management UI
        [Route("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
