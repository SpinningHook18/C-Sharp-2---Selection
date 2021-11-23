using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.WriteLine("{0} is divisible by 5 with no remainder", n);
            }
            else
            {
                Console.WriteLine("{0} is not exactly divisible by 5", n);
            }
            Console.ReadLine();
        }
    }
}
