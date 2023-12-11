using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Concrete
{
    public class MetroManager : IMetroService
    {
        private readonly IMetroDal metroDal;
        public MetroManager(IMetroDal metroDal)
        {
            this.metroDal = metroDal;
        }


        public void Activity(int id)
        {
            metroDal.Activity(id);
        }

        public void Add(Metro metro)
        {
            metroDal.Add(metro);
        }

        public void Delete(int id)
        {
            Metro metro = metroDal.Get(x => x.Id == id);
            metroDal.Delete(metro);
        }

        public async Task<List<Metro>> GetActiveMetros()
        {
            return await metroDal.GetActiveMetros();
        }

        public List<Metro> GetAllMetros()
        {
            return metroDal.GetAll();
        }

        public Metro GetMetro(int? id)
        {
            return metroDal.Get(x => x.Id == id);
        }

        public void Update(Metro metro)
        {
            metroDal.Update(metro);
        }
    }
}
