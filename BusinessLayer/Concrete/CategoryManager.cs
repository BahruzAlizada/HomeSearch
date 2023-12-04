﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }


        public void Activity(int id)
        {
            categoryDal.Activity(id);
        }

        public void Add(Category category)
        {
            categoryDal.Add(category);
        }

        public async Task<List<Category>> GetActiveCategoriesAsync()
        {
            return await categoryDal.GetActiveCategoriesAsync();
        }

        public List<Category> GetCategories()
        {
            return categoryDal.GetAll();
        }

        public Category GetCategory(int? id)
        {
            return categoryDal.Get(x => x.Id == id);
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
