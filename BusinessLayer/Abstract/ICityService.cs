using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Abstract
{
    public interface ICityService
    {
        Task<List<City>> GetAllCitiesAsync(string search, int take, int page);
        Task<List<City>> GetActiveCitiesAsync(string search, int take, int page);
        Task<double> PageCountActiveCitiesAsnc(double take);
        Task<double> PageCountAllCitiesAsync(double take);
        City GetCityById(int? id);
        void Add(City city);
        void Update(City city);
        void Delete(int id);
        void Activity(int id);
    }
}
