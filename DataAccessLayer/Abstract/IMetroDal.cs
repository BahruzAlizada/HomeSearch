using Core.DataAccess;
using EntityLayer.Concrete;
using System;


namespace DataAccessLayer.Abstract
{
    public interface IMetroDal : IRepositoryBase<Metro>
    {
        Task<List<Metro>> GetActiveMetros();
        void Activity(int id);
    }
}
