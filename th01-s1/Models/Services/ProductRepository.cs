﻿using th01_s1.Data;
using th01_s1.Models;
using th01_s1.Models.Interfaces;
namespace th01_s1.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private CoffeeshopDbContext dbContext;
        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }
        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}