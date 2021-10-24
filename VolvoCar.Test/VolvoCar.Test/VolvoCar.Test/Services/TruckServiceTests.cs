using Moq;
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
        [MemberData(nameof(TruckGenerator.GetDataTruckPass), MemberType = typeof(TruckGenerator))]
        //[MemberData(nameof(TruckGenerator.GetDataRegisterFailed), MemberType = typeof(TruckGenerator))]
        public void Post_RegisterNewTruck(Truck truck)
        {
            Assert.True(truckService.RegisterTruck(truck));
        }


        /// <summary>
        /// Teste semelhante aos outros, dando o update nos truck criados.
        /// </summary>
        /// <param name="truck"></param>
        [Theory]
        [MemberData(nameof(TruckGenerator.GetUpdateData_Pass), MemberType = typeof(TruckGenerator))]
        public void Put_UpdateTruck(Truck truck)
        {
            Assert.True(truckService.UpdateTruck(truck));
        }


        /// <summary>
        /// O método de teste a seguir tem como finalidade verificar se caso envie ID inexistente, o mesmo retorne uma exceção tratada
        /// do tipo TruckException
        /// </summary>
        /// <param name="id"></param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Get_FindTruckById(int id)
        { 
            Assert.Throws<TruckException>(() => truckService.FindObjectById(id));
        }

    }
}
