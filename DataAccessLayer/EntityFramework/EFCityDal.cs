using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.EntityFramework
{
    public class EFCityDal : EfRepositoryBase<City, Context>, ICityDal
    {
        public void Activity(int id)
        {
            using var context = new Context();

            City city = context.Cities.SingleOrDefault(x => x.Id == id);
            if (city.IsDeactive)
                city.IsDeactive = false;
            else
                city.IsDeactive = true;

            context.SaveChanges();
        }

        public async Task<List<City>> GetActiveCitiesAsync(string search, int take, int page)
        {
            using var context = new Context();

            List<City> cities = await context.Cities.Where(x =>!x.IsDeactive && (search == null || x.Name.Contains(search)))
                .OrderBy(x => x.Name).Skip((page - 1) * take).Take(take).ToListAsync();
            return cities;
        }

        public async Task<List<City>> GetAllCitiesAsync(string search, int take, int page)
        {
            using var context = new Context();

            List<City> cities = await context.Cities.Where(x=>(search==null || x.Name.Contains(search)))
                .OrderBy(x => x.Name).Skip((page-1) * take).Take(take).ToListAsync();
            return cities;
        }

        public async Task<double> PageCountActiveCitiesAsnc(double take)
        {
            using var context = new Context();

            double pageCount = Math.Ceiling(await context.Cities.Where(x => !x.IsDeactive).CountAsync() / take);
            return pageCount;
        }

        public async Task<double> PageCountAllCitiesAsync(double take)
        {
            using var context = new Context();

            double pageCount = Math.Ceiling(await context.Cities.CountAsync() / take);
            return pageCount;
        }
    }
}
