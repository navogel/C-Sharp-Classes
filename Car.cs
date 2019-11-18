namespace ClassIntro
{
//class name and properties are upper camel case
    class Car
    {
        public string Make {get; set;}
        public int Year {get; set;}
        public string Model {get; set;}
        public int Mileage {get; set;}
        public string Color {get; set;}
        public string CountryOfORigin {get; set;}
        public bool IsInspected {get; set;}

//create method - void does not return anything
        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }
    }



}