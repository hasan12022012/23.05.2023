using Microsoft.AspNetCore.Mvc;

namespace P138Allup.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Page = 2;
            return View();
        }
    }
}
