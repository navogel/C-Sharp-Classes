using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();
            Car ford = new Car("Ford", "Bronco", 80_000);
            
            ford.Year = 1986;
            ford.Color = "Pearl";
            ford.IsInspected = true;
            ford.CountryOfORigin = "USA";

            Car toyota = new Car("Toyota", "4Runner", 300)
            {
                
                Year = 2019,
                Color = "white",
                
                IsInspected = false,
                CountryOfORigin = "Japan"
            };

            Car chevy = new Car("chevy", "mali", 300000)
            {
               
                Year = 2016,
                Color = "pink",
                IsInspected = false,
                CountryOfORigin = "USA"
            };
             
            carLot.Add(ford);
            carLot.Add(toyota);
            carLot.Add(chevy);

            Console.WriteLine($"The ford has {ford.Mileage} miles");
            ford.Drive(10);
            Console.WriteLine($"The ford now has {ford.Mileage} miles");
            Console.WriteLine(ford.Description);
            Console.WriteLine(chevy.Description);
            Console.WriteLine(toyota.Description);




        
            
        }
    }
}
