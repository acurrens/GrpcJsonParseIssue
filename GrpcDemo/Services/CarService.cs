
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcDemo
{
    public class CarService : CarSvc.CarSvcBase
    {
        public override Task<CarList> GetAll(Empty request, ServerCallContext context)
        {
            var carList = new CarList();
            carList.Cars.Add(new Car(){ Id = 1, Make = "Mazda", Model = "CX5", Year = 2020 });
            carList.Cars.Add(new Car(){ Id = 2, Make = "Chevrolet", Model = "Chevelle", Year = 1970 });
            carList.Cars.Add(new Car(){ Id = 3, Make = "Ford", Model = "Mustang", Year = 1993 });
            carList.Cars.Add(new Car(){ Id = 4, Make = "Jeep", Model = "CJ7", Year = 1983 });
            carList.Cars.Add(new Car(){ Id = 5, Make = "Ford", Model = "Bronco", Year = 1978 });
            return Task.FromResult(carList);
        }
    }
}
