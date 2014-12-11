using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApps
{
    class Program
    {
        static void Main(string[] args)
    {
        double i;
        
    
	    int a = 0;
	    int b = 1;
	
	    for (i = 0; b < 100; i++)
	    {
	        int temp = a;
	         a = b;
	         b = temp + b;
             {
                 if(b<100)
                 Console.WriteLine(b);
             }
	    }
	
    
        
	   

            Console.ReadKey();

    }
    
   }
    
}
