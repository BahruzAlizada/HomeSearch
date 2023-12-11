using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.EntityFramework
{
    public class EFMetroDal : EfRepositoryBase<Metro, Context>, IMetroDal
    {
        public void Activity(int id)
        {
            using var context = new Context(); 

            Metro metro = context.Metros.SingleOrDefault(m => m.Id == id);
            if (metro.IsDeactive)
                metro.IsDeactive = false;
            else
                metro.IsDeactive = true;

            context.SaveChanges();
        }

        public async Task<List<Metro>> GetActiveMetros()
        {
            using var context = new Context();

            List<Metro> metros = await context.Metros.Where(x => !x.IsDeactive).ToListAsync();
            return metros;
        }
    }
}
