using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Interface;
using VolvoCar.Infra.Service;

namespace VolvoCar.Infra.Repository
{
    public class TruckRepository : ITruckRepository
    {
        private readonly ServiceRepository<Truck> _rep = new ServiceRepository<Truck>();

        public void CreateTruck(Truck obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteTruck(int id)
        {
            throw new NotImplementedException();
        }

        public Truck FindById(int? id)
        => _rep.FindById(id);

        public IQueryable<Truck> ListTruck()
        => _rep.List();

        public void UpdateTruck(Truck obj)
        => _rep.Update(obj);
    }
}
