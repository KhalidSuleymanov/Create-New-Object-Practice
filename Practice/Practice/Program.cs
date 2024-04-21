using System;
using System.Net.Http.Headers;
using Classes;

namespace MyHomeTasks31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Home Task
            Product prod = new Product();
            Drink drink = new Drink();

            prod.Name = "Alko";
            prod.Price = 60;
            drink.AlcoholPercent = 50;

            Console.WriteLine(prod.Name);
            Console.WriteLine(prod.Price);
            Console.WriteLine(drink.AlcoholPercent);
            #endregion

            Vehicle vehicle = new Vehicle();
            vehicle.Drive(10);
            vehicle.Drive(15);
            vehicle.Drive(20);
            Car car = new Car(80);
            car.FuelFor1Km = 1.1;

            car.AddFuel(25);
            car.AddFuel(35);
            car.AddFuel(50);
            car.AddFuel(10);
            car.AddFuel(20);
            car.AddFuel(23);

            car.FuelCapacity = 70;
            car.FuelCapacity = 10;
            car.FuelCapacity = 30;

            car.Drive(8);
            car.Drive(6);
            car.Drive(25);
            car.Drive(50);

            Console.WriteLine("Capacity:" + car.FuelCapacity);
            Console.WriteLine("Current:" + car.CurrentFuel);
            Console.WriteLine("Milleage:" + car.Milleage);
            Console.WriteLine(vehicle.Milleage);

        }
    }
}
