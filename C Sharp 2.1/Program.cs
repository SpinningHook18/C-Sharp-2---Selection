using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int examMark;
            Console.WriteLine("Enter exam mark:");
            examMark = Convert.ToInt32(Console.ReadLine());
            if (examMark < 0 || examMark > 100)
            {
                Console.WriteLine("Mark not in range");
            }
            else
            {
                Console.WriteLine("Mark is in range");
            }
            Console.ReadLine();
        }
    }
}
