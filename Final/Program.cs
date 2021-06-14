using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables declared here  //
            double miles, gallons = 0;  //
            double mpg;                 //
            string again = "y";         //
            bool insertMiles = false;   //
            bool insertGallons = false; //
            //__________________________//

            while (again == "y")
            {
                do
                {
                    // Get miles driven, checks if user input is valid and assign to miles
                    
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Please enter the distance to be traveled in miles.");
                    insertMiles = double.TryParse(Console.ReadLine(), out miles);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is not a valid input");

                }
                while (!insertMiles);
                Console.Clear();
                do
                {
                    // Get gallons used, checks if user input is valid and assign to gallons
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Now enter the number of gallons used.");
                    insertGallons = double.TryParse(Console.ReadLine(), out gallons);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is not a valid input");
                }
                while (!insertGallons);

                // Calculate mpg MUST (cast) variables to force decimal math.
                mpg = miles / gallons;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                //Here I put a code to decrease the decimal places to just 3 digits after the period.
                Console.WriteLine($"The number of miles per gallon is: {String.Format("{0:0.000}",mpg)}\n");

                //Here the user is asked if he wants to reset the application or close it.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Would you like to perform another calculation? (Y/N)");
                again = Console.ReadLine().ToLower();
                Console.Clear();
                if (again != "y")
                {
                    Console.WriteLine("Thanks for using the application GoodBye... =D");
                }
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
