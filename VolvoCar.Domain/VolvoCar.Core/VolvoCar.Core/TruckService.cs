using System;
using System.Linq;
using System.Threading.Tasks;
using VolvoCar.Domain.Exception;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Repository;

namespace VolvoCar.Core
{
    public class TruckService : ITruckService
    {
        private readonly TruckRepository _rep = new();
        public void RegisterTruck(Truck truck) => _rep.CreateTruck(truck);

        public void DeleteTruck(int id)
        {
            try
            {
                _rep.DeleteTruck(id);
            }
            catch (Exception e)
            {
                throw new TruckException(e.Message);
            }
        }

        public IQueryable<Truck> ListAllTruck() => _rep.ListTruck();

        public void UpdateTruck(Truck truck)
        {
            try
            {
                _rep.UpdateTruck(truck);
            }
            catch (Exception e)
            {
                throw new TruckException(e.Message);
            }
        }

        public Truck FindObjectById(int? id)
        {
            Truck truck = _rep.FindById(id);

            if (truck.Equals(null))
                throw new TruckException($"Não encontrado caminhão para o Id {id}");

            return truck;

        }
    }
}
