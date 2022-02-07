using System.Threading.Tasks;
using NLayer.Core.Models;

namespace NLayer.Core.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}