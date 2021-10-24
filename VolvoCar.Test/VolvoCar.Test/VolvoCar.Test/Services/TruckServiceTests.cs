using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoCar.Core;
using VolvoCar.Domain.Exception;
using VolvoCar.Domain.Model;
using VolvoCar.Infra.Interface;
using VolvoCar.Test.Generator;
using Xunit;

namespace VolvoCar.Test.Services
{
    public class TruckServiceTests
    {
        private TruckService truckService;

        public TruckServiceTests()
        {
            truckService = new TruckService(new Mock<ITruckRepository>().Object);
        }


        /// <summary>
        /// Para a validação dar certo, deixe o GetDataRegisterPass descomentada, para dar erro deixe o GetDataRegisterFailed descomentada
        /// </summary>
        /// <param name="truck"></param>
        [Theory]
        [MemberData(nameof(TruckGenerator.GetDataRegisterPass), MemberType = typeof(TruckGenerator))]
     // [MemberData(nameof(TruckGenerator.GetDataRegisterFailed), MemberType = typeof(TruckGenerator))]
        public void Create_RegisterNewTruck(Truck truck)
        {
            Assert.True(truckService.RegisterTruck(truck));
        }
    }
}
