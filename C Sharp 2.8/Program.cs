using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2, name3;
            
            Console.WriteLine("Enter name 1:");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter name 2:");
            name2 = Console.ReadLine();
            Console.WriteLine("Enter name 3:");
            name3 = Console.ReadLine();

            

            string[] names = new string[]
            {
                name1,
                name2,
                name3
            };

            Array.Sort(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
          
        }
    }
}
