using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            //myCar.Make = "Oldmobile";
            //myCar.Model = "Cutlas Supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";

            //Car myOtherCar;
            //myOtherCar = myCar;

            //Console.WriteLine("{0} {1} {2} {3}",
            //    myOtherCar.Make, 
            //    myOtherCar.Model, 
            //    myOtherCar.Year, 
            //    myOtherCar.Color );

            //myOtherCar.Model = "98";

            //Console.WriteLine("{0} {1} {2} {3}",
            //   myCar.Make,
            //   myCar.Model,
            //   myCar.Year,
            //   myCar.Color);

            //myOtherCar = null;

            //Console.WriteLine("{0} {1} {2} {3}",
            //   myOtherCar.Make,
            //   myOtherCar.Model,
            //   myOtherCar.Year,
            //   myOtherCar.Color);


        }
    }
}
