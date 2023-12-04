using Core.DataAccess;
using EntityLayer.Concrete;
using System;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepositoryBase<Category>
    {
        Task<List<Category>> GetActiveCategoriesAsync();
        void Activity(int id);
    }
}
