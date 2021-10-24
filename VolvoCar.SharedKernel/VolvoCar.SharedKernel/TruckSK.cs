using System;
using VolvoCar.Domain.Exception;
using VolvoCar.Domain.Model;

namespace VolvoCar.SharedKernel
{
    public class TruckSK
    {
        public bool InvalidId(int id, int _id)
        {
            bool isValid = id != _id ? true : false;
            return isValid;
        }


        public void ValidatedTruck(Truck truck)
        {
            if (!truck.ModelName.Equals("FM") && !truck.ModelName.Equals("FH"))
                throw new TruckException("Modelo não permitido!");

            if (!truck.YearFabrication.Equals(DateTime.Now.Year)
                && !truck.YearModel.Equals(DateTime.Now.Year)
                && !truck.YearModel.Equals(DateTime.Now.AddYears(1).Year))
                throw new TruckException("Ano de fabricação ou do modelo tem que ser igual ao especificado!");
        }
    }
}
