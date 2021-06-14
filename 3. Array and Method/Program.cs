using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Array_and_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = { 34.7, 56.9, 75, 52, 92.2 };

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"The size of the array is {grades.Length}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nThe second value is {grades[1]}");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nEach value in the array");
            foreach (var a in grades)
            {
                Console.WriteLine(a);
            }
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
