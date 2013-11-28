using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    /// <summary>
    /// A class that handles all the operations of a calculator
    /// </summary>
    class Calculator
    {
        private Number num1;
        private Number num2;
        private double results;

        public Calculator()
        {
            num1 = new Number();
            num2 = new Number();

            chooseOperation();
        }

        public void chooseOperation()
        {
            int i = 0;

            String s = "\nOptions:\n";
            s += "\t 1: Addition\n";
            s += "\t 2: Subtraction\n";
            s += "\t 3: Multiplication\n";
            s += "\t 4: Division\n";
            s += "\n\t Choose an operation: ";
            Console.Write(s);

            if (!int.TryParse(Console.ReadLine(), out i) || (i < 1) || (i > 4))
                throw new Exception("operation **");

            switch (i)
            {
                case 1: add(); break;
                case 2: subtract(); break;
                case 3: multiply(); break;
                case 4: divide(); break;
            }

            print();
        }

        private void add()
        {
            results = num1.getNum() + num2.getNum();
        }

        private void subtract()
        {
            results = num1.getNum() - num2.getNum();
        }

        private void multiply()
        {
            results = num1.getNum() * num2.getNum();
        }

        private void divide()
        {
            results = num1.getNum() / num2.getNum();
        }

        private void print()
        {
            Console.WriteLine("\nThe result is: {0}", results);
        }

    }
}
