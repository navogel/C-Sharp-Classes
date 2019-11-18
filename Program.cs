using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();
            Car ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Bronco";
            ford.Year = 1986;
            ford.Color = "Pearl";
            ford.Mileage = 80_000;
            ford.IsInspected = true;
            ford.CountryOfORigin = "USA";

            Car toyota = new Car()
            {
                Make = "Toyota",
                Model = "4Runner",
                Year = 2019,
                Color = "white",
                Mileage = 300,
                IsInspected = false,
                CountryOfORigin = "Japan"
            };

            Car chevy = new Car()
            {
                Make = "chevy",
                Model = "mali",
                Year = 2016,
                Color = "pink",
                Mileage = 300000,
                IsInspected = false,
                CountryOfORigin = "USA"
            };
             
            carLot.Add(ford);
            carLot.Add(toyota);
            carLot.Add(chevy);

            Console.WriteLine($"The ford has {ford.Mileage} miles");
            ford.Drive(10);
            Console.WriteLine($"The ford now has {ford.Mileage} miles");


        
            
        }
    }
}
