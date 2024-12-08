﻿using Entities.Models;

namespace Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryById(int id);
    }
}