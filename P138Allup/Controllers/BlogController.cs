using Microsoft.AspNetCore.Mvc;

namespace P138Allup.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Page = 4;
            return View();
        }
    }
}
