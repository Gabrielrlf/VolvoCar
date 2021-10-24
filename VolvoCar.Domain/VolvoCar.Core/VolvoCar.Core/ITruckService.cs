using System.Linq;
using VolvoCar.Domain.Model;

namespace VolvoCar.Core
{
    public interface ITruckService
    {
        bool RegisterTruck(Truck truck);
        void DeleteTruck(int id);
        IQueryable<Truck> ListAllTruck();
        bool UpdateTruck(Truck truck);
        Truck FindObjectById(int? id);
    }
}
