using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repository;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System.Linq.Expressions;

namespace NLayer.Caching
{
    public class ProductServiceWithCashing : IProductService
    {
        private readonly IProductRepository _productRepository;
        private const string CacheProductKey = "productsCache";
        private readonly Mapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly IUnitOfWork _unitOfWork;

        public ProductServiceWithCashing(Mapper mapper, IProductRepository productRepository, IMemoryCache memoryCache, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _memoryCache = memoryCache;
            _unitOfWork = unitOfWork;
            if (!_memoryCache.TryGetValue(CacheProductKey, out _))
            {
                _memoryCache.Set(CacheProductKey, _productRepository.GetAll().ToList());
            }
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> Where(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveRangeAsync(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            throw new NotImplementedException();
        }
    }
}