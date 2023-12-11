using Core.DataAccess;
using EntityLayer.Concrete;
using System;

namespace DataAccessLayer.Abstract
{
    public interface ICityDal : IRepositoryBase<City>
    {
        Task<List<City>> GetAllCitiesAsync(string search, int take, int page);
        Task<List<City>> GetActiveCitiesAsync(string search, int take, int page);
        Task<double> PageCountActiveCitiesAsnc(double take);
        Task<double> PageCountAllCitiesAsync(double take);
        void Activity(int id);
    }
}
