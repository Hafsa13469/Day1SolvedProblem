using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Console.WriteLine("Please Enter number 1");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter number2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition result: {0}", n1 + n2);
            Console.WriteLine("Subtraction result: {0}", n1 - n2);
            Console.WriteLine("Multiplition result: {0}", n1 * n2);
            Console.WriteLine("Division result: {0}", n1 / n2);


            Console.ReadKey();
        }
    }
}
