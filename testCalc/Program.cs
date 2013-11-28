using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the epic and overly complicated calculator.\n\n");
                Calculator calc = new Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n\t ** You have entered an invalid " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
