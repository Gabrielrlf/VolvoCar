using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using VolvoCar.Infra.Service.Interface;

namespace VolvoCar.Infra.Service
{
    public class ServiceRepository<T> : IDisposable, IService<T> where T : class
    {
        protected readonly VolvoCarDbContext dbContext = new VolvoCarDbContext();


        public void Create(T obj)
        {
            dbContext.Set<T>().Add(obj);

            dbContext.SaveChanges();
        }

        public void Delete(T obj)
        {
            dbContext.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Dispose() => dbContext.Dispose();
        

        public T FindById(int? id) => dbContext.Find<T>(id);

        public IQueryable<T> List() => dbContext.Set<T>();

        public void Update(T obj)
        {
            dbContext.Entry(obj).State = EntityState.Modified;

            dbContext.SaveChanges();
        }
    }
}
