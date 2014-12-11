using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please Enter Your Name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hi " + name + " Good Day ");

            Console.ReadKey();


        }
    }
}
