using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            dbContext.DisposeAsync();
        }

        public IQueryable<T> List()
        {
            return dbContext.Set<T>();
        }

        public void Update(T obj)
        {
            dbContext.Entry(obj).State = EntityState.Modified;

            dbContext.SaveChanges();
        }
    }
}
