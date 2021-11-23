using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, drive;
            bool passed;
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter if you have passed driving test, true or false:");
            passed = Convert.ToBoolean(Console.ReadLine());
            if (age > 21 && passed == true)
            {
                Console.WriteLine("You can drive the minibus");
            }
            else
            {
                Console.WriteLine("You cannot drive the minibus");
            }
            Console.ReadLine();
        }
    }
}
