using Microsoft.AspNetCore.Mvc;

namespace P138Allup.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Page = 3;
            return View();
        }
    }
}
