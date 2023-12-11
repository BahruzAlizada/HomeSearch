using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal cityDal;
        public CityManager(ICityDal cityDal)
        {
            this.cityDal = cityDal;
        }


        public void Activity(int id)
        {
            cityDal.Activity(id);
        }

        public void Add(City city)
        {
            cityDal.Add(city);
        }

        public void Delete(int id)
        {
            City city = cityDal.Get(x => x.Id == id);
            cityDal.Delete(city);
        }

        public async Task<List<City>> GetActiveCitiesAsync(string search, int take, int page)
        {
            return await cityDal.GetActiveCitiesAsync(search,take, page);
        }

        public async Task<List<City>> GetAllCitiesAsync(string search, int take, int page)
        {
            return await cityDal.GetAllCitiesAsync(search,take, page);
        }

        public City GetCityById(int? id)
        {
            return cityDal.Get(x => x.Id == id);
        }

        public async Task<double> PageCountActiveCitiesAsnc(double take)
        {
            return await cityDal.PageCountActiveCitiesAsnc(take);
        }

        public async Task<double> PageCountAllCitiesAsync(double take)
        {
            return await cityDal.PageCountAllCitiesAsync(take);
        }

        public void Update(City city)
        {
            cityDal.Update(city);
        }
    }
}
