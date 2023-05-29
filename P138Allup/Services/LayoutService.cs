using Microsoft.EntityFrameworkCore;
using P138Allup.DataAccessLayer;
using P138Allup.InterFaces;
using P138Allup.Models;

namespace P138Allup.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.Include(c=>c.Children.Where(c=>c.IsDeleted==false))
                .Where(c => c.IsDeleted == false && c.IsMain).ToListAsync();
        }

        public async Task<List<Setting>> GetSetting() 
        {
            List<Setting> settings = await _context.Settings.ToListAsync();

            return settings;
        }
    }
}
