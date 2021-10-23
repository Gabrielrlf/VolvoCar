using System;
using VolvoCar.Domain.Exception;

namespace VolvoCar.SharedKernel
{
    public class TruckSK
    {
        public bool InvalidId(int id, int _id)
        {
            bool isValid = id != _id ? true : false;
            return isValid;
        }
    }
}
