using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoCar.Domain.Model;

namespace VolvoCar.Infra.Interface
{
    public interface ITruckRepository
    {
        void CreateTruck(Truck obj);
        void DeleteTruck(int id);
        void UpdateTruck(Truck obj);
        IQueryable<Truck> ListTruck();
        Truck FindById(int? id);
    }
}
