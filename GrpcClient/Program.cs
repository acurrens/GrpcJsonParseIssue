using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcDemo;
using System;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel chn = new Channel("127.0.0.1:5000",ChannelCredentials.Insecure);
            var grpcClient = new CarSvc.CarSvcClient(chn);
            var results = grpcClient.GetAll(new Empty());
            foreach (var c in results.Cars)
            {
                Console.WriteLine($"Id: {c.Id} | Year: {c.Year} | Make: {c.Make} | Model: {c.Model} ");
            }
            
            string newCarJson = @"{""cars"": [
                    { ""id"":6,""make"":""Nissan"",""model"":""GT-R"",""year"":2017},
                    { ""id"":7,""make"":""BMW"",""model"":""M3"",""year"":2005, ""engine"":""I6""},
                    { ""id"":8,""make"":""Chevrolet"",""model"":""Bel Air"",""year"":1957, ""engine"":""V8""}
                     ]
                    }";

            var parser = CarList.Parser.WithDiscardUnknownFields(true);
            var cList = parser.ParseJson(newCarJson);

            foreach (var c in cList.Cars)
            {
                Console.WriteLine($"Id: {c.Id} | Year: {c.Year} | Make: {c.Make} | Model: {c.Model} ");
            }
            Console.ReadLine();
        }
    }
}
