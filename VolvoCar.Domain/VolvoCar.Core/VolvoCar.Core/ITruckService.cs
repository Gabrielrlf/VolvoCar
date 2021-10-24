using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoCar.Domain.Model;

namespace VolvoCar.Core
{
    public interface ITruckService
    {
        bool RegisterTruck(Truck truck);
        void DeleteTruck(int id);
        IQueryable<Truck> ListAllTruck();
        void UpdateTruck(Truck truck);
        Truck FindObjectById(int? id);
    }
}
