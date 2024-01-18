using VShop.Web.Models;

namespace VShop.Web.Services.Contratos;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}
