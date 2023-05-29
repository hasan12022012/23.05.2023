using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P138Allup.DataAccessLayer;
using P138Allup.Services;
using P138Allup.ViewModels.HomeVMs;

namespace P138Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //ViewBag.Page = 1;
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain).ToListAsync(),
                BestSeller = await _context.Products.Where(p => p.IsDeleted == false && p.IsBestSeller).ToListAsync(),
                NewArrivals = await _context.Products.Where(p => p.IsDeleted == false && p.IsNewArrival).ToListAsync(),
                Featured = await _context.Products.Where(p => p.IsDeleted == false && p.IsFeatured).ToListAsync()
            };
            return View(homeVM);  
        }
    }
}
