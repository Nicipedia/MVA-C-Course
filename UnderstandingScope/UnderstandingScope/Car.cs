using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Car
    {
        
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
