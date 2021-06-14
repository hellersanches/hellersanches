using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Age_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Name();
            Console.Clear();
            int isYear = YearCalc();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{name1} you were born in {isYear}");
            Console.ForegroundColor = ConsoleColor.White;


        }
        public static string Name()
        {
            string isName;
            
            Console.WriteLine("Hi, What's your name?");
            isName = Console.ReadLine();
            return isName;
        }

        public static int Age()
        {
            bool isAge = false;
            int age = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How old are you?");
                isAge = int.TryParse(Console.ReadLine(), out age);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("That is not a valid input");
            }
            while (!isAge);
            Console.Clear();
            return age;
        }

        public static int YearCalc()
        {
            int yearNow = DateTime.Now.Year;
            int year;

            year = yearNow - Age();
            return year;
        }
        

    }
}
