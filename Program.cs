using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car someCar = new Car();
            someCar.Make = "ford";
            Console.WriteLine(someCar.make);
        }
    }
}
