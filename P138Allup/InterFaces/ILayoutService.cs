using P138Allup.Models;

namespace P138Allup.InterFaces
{
    public interface ILayoutService
    {
        Task<List<Setting>> GetSetting();
        Task<IEnumerable<Category>> GetCategories();
    }
}
