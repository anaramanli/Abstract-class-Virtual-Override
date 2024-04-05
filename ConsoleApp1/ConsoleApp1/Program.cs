using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            /*Car car = new Car("Mercedes", "G - Wagon", "Grey", 30m, 120m, 4, false, "benzin");
            Car tesla = new("Tesla", "Model-S plaid", "white", 4m, 500, 4, true, "electric");
            Bicycle bicycle = new Bicycle("xxx", "Munnar Road Bike", "", 30m, 60m,"race", "none");

            // Calling methods
            car.AverageSpeed();
            car.GetInfo();
            car.harm();

            bicycle.AverageSpeed();
            bicycle.GetInfo();
            bicycle.harm();

            tesla.AverageSpeed();
            tesla.GetInfo();
            tesla.harm();*/


            Car[] cars =
            {
                new Car("Mercedes", "G-Wagon", "Grey", 30m, 120m,4,false,"benzin"),
                new Car("BMW", "X5", "Black", 25m, 110m,4,false,"benzin"),
                new("Tesla", "Model-S plaid", "white", 4m, 500, 4, true, "electric")
            };

            Bicycle[] bicycles =
            {
                new Bicycle("xxx", "Munnar Road Bike", "", 30m, 60m, "Road", "none"),
                new Bicycle("xxx", "Munnar Race Bike", "", 30m, 60m, "race", "none")
            };

            foreach (var car in cars)
            {
                car.GetInfo();
                Console.WriteLine();
            }
            foreach (var bicylce in bicycles)
            {
                bicylce.GetInfo();
                Console.WriteLine();
            }
        }
    }
}
