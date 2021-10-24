using System;
using System.Linq;
using VolvoCar.Domain.Exception;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Interface;
using VolvoCar.SharedKernel;

namespace VolvoCar.Core
{
    public class TruckService : ITruckService
    {
        TruckSK truckSK = new();
        private readonly ITruckRepository _rep;

        public TruckService(ITruckRepository rep) => _rep = rep;
        public bool RegisterTruck(Truck truck)
        {
            try
            {
                truckSK.ValidatedTruck(truck);

                _rep.CreateTruck(truck);
                return true;
            }
            catch (Exception e)
            {
                throw new TruckException(e.Message);
            }
        }

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

        public bool UpdateTruck(Truck truck)
        {
            try
            {
                truckSK.ValidatedTruck(truck);

                _rep.UpdateTruck(truck);
                return true;
            }
            catch (Exception e)
            {
                throw new TruckException(e.Message);
            }
        }

        public Truck FindObjectById(int? id)
        {
            Truck truck = _rep.FindById(id);

            if (truckSK.IsNull(truck))
                throw new TruckException($"Não encontrado caminhão para o Id {id}");

            return truck;

        }
    }
}
