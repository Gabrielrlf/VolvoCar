using System;
using System.Linq;
using System.Threading.Tasks;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Repository;

namespace VolvoCar.Core
{
    public class TruckBLL
    {
        private readonly TruckRepository _rep = new();
        public void RegisterTruck(Truck truck) => _rep.CreateTruck(truck);

        public void DeleteTruck(int id) => _rep.DeleteTruck(id);

        public IQueryable<Truck> ListAllTruck() => _rep.ListTruck();

        public void UpdateTruck(Truck truck) => _rep.CreateTruck(truck);
    }
}
