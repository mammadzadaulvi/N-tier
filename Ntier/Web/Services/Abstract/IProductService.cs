using Web.ViewModels.Product;
using Web.ViewModels.Product.ProductPhotos;

namespace Web.Services.Abstract
{
    public interface IProductService
    {
        Task<ProductIndexVM> GetAllAsync();

        Task<ProductCreateVM> GetCreateModelAsync();
        Task<bool> CreateAsync(ProductCreateVM model);

        Task<ProductUpdateVM> GetUpdateModelAsync(int id);
        Task<bool> UpdateAsync(ProductUpdateVM model);

        Task<bool> DeleteAsync(int id);

        #region Photos
        Task<bool> DeletePhotoAsync(int id);
        Task<bool> UpdatePhotoAsync(ProductPhotoUpdateVM model);
        Task<ProductPhotoUpdateVM> GetPhotoUpdateModelAsync(int id);
        #endregion

    }
}
