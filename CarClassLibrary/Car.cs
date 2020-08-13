using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        //Car myNewSportsCar = new Car("Ford", "Mustang", 19500);
        //Car genericCar = new Car();

        public String Make { get; set; }
        public String Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }
        public Car (string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} ${2}", Make, Model, Price);
            }
        }
    }
}