using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inches, Centimetres;
            Console.WriteLine("Enter number of inches");
            Inches = Convert.ToDouble(Console.ReadLine());
            Centimetres = 2.54 * Inches;
            Console.WriteLine("Number of centimetres = {0:N2}", Centimetres);
            Console.ReadLine();

            
        }
    }
}
