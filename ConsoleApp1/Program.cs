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
            int x;
            int y;
            int result;
            Console.WriteLine("\n Enter the first number to be added");
            x = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("\n Enter the second number to be added");
            y = Convert.ToInt32(Console.ReadLine());
            result = x + y;
            Console.WriteLine("\n The sum of two numbers is" +result);
            Console.ReadLine();

        }
    }
}
