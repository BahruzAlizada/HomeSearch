using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetActiveCategoriesAsync();
        List<Category> GetCategories();
        Category GetCategory(int? id);
        void Add(Category category);
        void Update(Category category);
        void Activity(int id);
    }
}
