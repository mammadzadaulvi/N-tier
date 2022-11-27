using Web.Area.Admin.ViewModels.Category;

namespace Web.Area.Admin.Services.Abstract
{
    public interface ICategoryService
    {
        Task<CategoryIndexVM> GetAllAsync();
    }
}
