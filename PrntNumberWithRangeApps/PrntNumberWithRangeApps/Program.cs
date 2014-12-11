using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrntNumberWithRangeApps
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2,lower,upper;

            Console.WriteLine("Please Enter number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            //lower = Convert.ToInt32(Console.ReadLine());
            //upper = Convert.ToInt32(Console.ReadLine());

            {
                if (n1 > n2)
                {
                    Console.WriteLine("Lower Number is: {0}", n2);

                    Console.WriteLine("Upper Number is: {0}", n1);

                    lower = n2;
                    upper = n1;
                }
                else
                {
                    Console.WriteLine("Lower Number is: {0}", n1);
                    Console.WriteLine("Upper Number is: {0}", n2);

                    lower = n1;
                    upper = n2;
                }
                
                
                {
                   
                    for (int i = lower; i <= upper; i++)
                    {
                        Console.WriteLine("The Numbers are: {0}", i);
                        Console.WriteLine();
                    }

                }



            }
            
            Console.ReadKey();

            }
        }
    }
