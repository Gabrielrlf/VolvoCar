using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoCar.Domain.Exception
{
    public class TruckException : ArgumentException
    {
        public TruckException(string message) : base(message)
        {
        }
    }
}
