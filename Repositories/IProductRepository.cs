﻿using Entities;

namespace Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProducts();
    }
}