using System;

namespace VolvoCar.Domain.Exception
{
    public class TruckException : ArgumentException
    {
        public TruckException(string message) : base(message)
        {
        }
    }
}
