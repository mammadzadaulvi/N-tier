using DataAccess.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Web.Area.Admin.Services.Abstract;
using Web.Area.Admin.ViewModels.Category;

namespace Web.Area.Admin.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ModelStateDictionary _modelState;

        public CategoryService(ICategoryRepository categoryRepository, IActionContextAccessor actionContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _modelState = actionContextAccessor.ActionContext.ModelState;
        }

        public async Task<CategoryIndexVM> GetAllAsync()
        {
            var model = new CategoryIndexVM
            {
                Categories = await _categoryRepository.GetAllAsync()
            };
            return model;
        }
    }
}
