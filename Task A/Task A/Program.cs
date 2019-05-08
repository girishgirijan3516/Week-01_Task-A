using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, total = 0; // Declare and initialize variables
            for (i = 314; i >= 102; i -= 6)
            {      // Begining of loop  
                   //Console.WriteLine (i);
                total += i; // counting total
            }
            Console.WriteLine("Total = " + total); // Display total  
        }
    }
}
