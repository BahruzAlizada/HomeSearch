using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Abstract
{
    public interface IMetroService
    {
        Task<List<Metro>> GetActiveMetros();
        List<Metro> GetAllMetros();
        Metro GetMetro(int? id);
        void Add(Metro metro);
        void Update(Metro metro);
        void Delete(int id);
        void Activity(int id);
    }
}
