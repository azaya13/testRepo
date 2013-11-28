using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    /// <summary>
    /// A class that acts as an overly complex version of an integer
    /// </summary>
    class Number
    {
        double n1;

        public Number()
        {
            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out n1))
                throw new Exception("number **");
        }

        public double getNum()
        {
            return n1;
        }
    }
}
