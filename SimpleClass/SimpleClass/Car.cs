using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public decimal DetemineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 100000;
            else
                carValue = 20000;

            return carValue;
        }
    }
}
