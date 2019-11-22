using System;

namespace ClassIntro
{
//class name and properties are upper camel case
    class Car
    {
        //This is a field
        //They are similar to properties but they are typically private
        //and dont specify getters and setters
        private string _vinNumber;

        private int _standardTestDrive = 5;
        //constructor
        public Car(string make, string model, int mileage)
        {       
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(11_111, 99_999).ToString();
        }

        //properties
        public string Make {get; set;}
        public int Year {get; set;}
        public string Model {get; set;}
        //private set blocks program from changing "mileage" outside of class methods
        public int Mileage {get; private set;}
        public string Color {get; set;}
        public string CountryOfORigin {get; set;}
        public bool IsInspected {get; set;}
        public string Description 
        {
            get 
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }

        }

//create method - void does not return anything
        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }
//the method doesnt take an int
//method signature:  name of method, type of param(s), return type.
        public void Drive()
        {
            Mileage =+ _standardTestDrive;
        }
    }



}