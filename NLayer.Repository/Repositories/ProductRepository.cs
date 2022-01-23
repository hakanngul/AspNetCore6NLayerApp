﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repository;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWitCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}