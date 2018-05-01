using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor

        //public Car()
        //{

        //    this.Make = "Nissan";
        //}

        //public Car(string make, string model, int year, string color)
        //{
        //    Make = make;
        //    Model = model;
        //    Year = year;
        //    Color = color;
             

        //}

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);
        }
    }
}
