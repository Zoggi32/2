using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 5 && num1 < 10)
            {
                Console.WriteLine("Number greater Then 5 and less then 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
            Console.ReadKey();
        }
    }
}
