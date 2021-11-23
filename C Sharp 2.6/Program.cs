using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Enter exam mark: ");
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("Mark is out of bounds");
            }
            if (mark > 0 && mark <= 39)
            {
                Console.WriteLine("Grade U");
            }
            if (mark > 39 && mark <= 49)
            {
                Console.WriteLine("Grade E");
            }
            if (mark > 49 && mark <= 59)
            {
                Console.WriteLine("Grade D");
            }
            if (mark > 59 && mark <= 69)
            {
                Console.WriteLine("Grade C");
            }
            if (mark > 69 && mark <= 79)
            {
                Console.WriteLine("Grade B");
            }
            if (mark > 79 && mark <= 100)
            {
                Console.WriteLine("Grade U");
            }
            Console.ReadLine();
        }
    }
}
