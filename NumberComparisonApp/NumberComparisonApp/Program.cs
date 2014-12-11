using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Please Enter number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            n2 = Convert.ToInt32(Console.ReadLine());
            {
                if (n1 > n2)
                {
                    Console.WriteLine("Small Number is: {0}", n2);

                    Console.WriteLine("Large Number is: {0}", n1);
                }
                else
                {
                    Console.WriteLine("Small Number is: {0}", n1);
                    Console.WriteLine("Large Number is: {0}", n2);
                }

                Console.ReadKey();



            }
        }
    }
}
