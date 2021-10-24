using System.Linq;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Interface;
using VolvoCar.Infra.Service;

namespace VolvoCar.Infra.Repository
{
    public class TruckRepository : ITruckRepository
    {
        private readonly ServiceRepository<Truck> _rep = new ServiceRepository<Truck>();

        public void CreateTruck(Truck obj)
        => _rep.Create(obj);

        public void DeleteTruck(int id)
        {
            Truck truck = _rep.FindById(id);
            _rep.Delete(truck);
        }

        public Truck FindById(int? id)
        => _rep.FindById(id);

        public IQueryable<Truck> ListTruck()
        => _rep.List();

        public void UpdateTruck(Truck obj)
        => _rep.Update(obj);
    }
}
