using System.Collections.Generic;
using System.Threading.Tasks;
using NLayer.Core.Models;

namespace NLayer.Core.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();
    }
}