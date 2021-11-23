using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter number 1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("{0} is bigger than {1} and {2}", n1, n2, n3);
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("{0} is bigger than {1} and {2}", n2, n1, n3);
            }
            if (n2 == n1 && n1 == n3)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("{0} is bigger than {1} and {2}", n3, n1, n2);
            }
            Console.ReadLine();
        }
    }
}
