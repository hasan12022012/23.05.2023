using Microsoft.AspNetCore.Mvc;

namespace P138Allup.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Page = 5;
            return View();
        }
    }
}
