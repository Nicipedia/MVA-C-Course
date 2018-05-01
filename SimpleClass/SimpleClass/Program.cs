using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = " Cutlas Surpreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            //decimal value = DetemineMarketValue(myCar);
            //Console.WriteLine("{0:C} ", value);

            Console.WriteLine("{0:C}", myCar.DetemineMarketValue());
        }
            private static decimal DetemineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue; 

        }


        }
    }

