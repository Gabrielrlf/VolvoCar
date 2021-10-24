using System;
using System.Collections.Generic;
using VolvoCar.Domain.Model;

namespace VolvoCar.Test.Generator
{
    public class TruckGenerator
    {
        public static IEnumerable<object[]> GetDataTruckPass()
        {
            yield return new object[]
           {
                new Truck {Id = 11, ModelName = "FH", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 12, ModelName = "FM", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 13, ModelName = "FM", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.AddYears(1).Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 14, ModelName = "FH", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now }
           };
        }


        public static IEnumerable<object[]> GetDataTruckFailed()
        {
            yield return new object[]
           {
                new Truck {Id = 11, ModelName = "FD", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 12, ModelName = "FD", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 13, ModelName = "FM", YearFabrication = DateTime.Now.AddYears(1).Year, YearModel = DateTime.Now.AddYears(2).Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 14, ModelName = "FC", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now }
           };
        }

        public static IEnumerable<object[]> GetUpdateData_Pass()
        {
            yield return new object[]
           {
                new Truck {Id = 2, ModelName = "FH", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };

            yield return new object[]
           {
              new Truck {Id = 1, ModelName = "FM", YearFabrication = DateTime.Now.Year, YearModel = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now },
           };
        }
    }
}
