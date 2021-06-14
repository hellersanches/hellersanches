using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables declared here_______________
            int Guess, Number = 0, attempts = 0;  //
            bool isGuess = false;                //
            bool isNumber = false;               //
            string again = "y";                 //
            //_________________________________//


            //Here we start capturing the values ​​entered by the user (Player 1)
            //in case the value is different from the one required by the application                  
            //the user will enter a Loop until it enters the value accepted by the application.         
            while (again == "y")
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nReady Player 1?\nEnter a number between 1 - 100 e pressione enter");
                    isNumber = int.TryParse(Console.ReadLine(), out Number);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("That is not a valid input");
                }
                while (Number < 1 || Number > 100 || !isNumber);


                //Here there is a pause in the application to replace Player 1 with Player 2
                //and start guessing the number entered by Player 1.

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNow it's player 2's turn to guess the number.\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();

                //Here the user is asked to enter a number where he believes it is the number chosen by player 1
                //and in the same way that the first data entry the user is forced to enter a value accepted by
                //the application through a loop.
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nReady Player 2?\nEnter a number between 1 - 100");
                    isGuess = int.TryParse(Console.ReadLine(), out Guess);

                    while (Guess < 1 || Guess > 100 || !isGuess)
                    {
                        Console.Clear();
                        Console.WriteLine("That is not a valid input\nEnter a number between 1 - 100");
                        isGuess = int.TryParse(Console.ReadLine(), out Guess);
                    }

                    //Here the verification of the number entered by player 2 takes place and compared to
                    //the number chosen by player 1 in case of being equal, player 2 wins the game.

                    if (Guess == Number)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Congratulations you guessed the number !!");
                        break;
                    }

                    //Here we look at the attempts that player 2 used

                    else if (attempts < 2)
                    {
                        if (attempts == 0)
                        {
                            Console.Clear();

                            if (Guess < Number)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Console.WriteLine("**Try Higher**\nyou have 2 attempts left");
                            }
                            else if (Guess > Number)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Console.WriteLine("**Try Less**\nyou have 2 attempts left");
                            }
                        }
                        else
                        {
                            Console.Clear();

                            if (Guess < Number)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("**Try Higher**\nyou have 1 attempt left");
                            }
                            else if (Guess > Number)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("**Try Less**\nyou have 1 attempt left");
                            }
                        }
                    }

                    // In case of all attempts gone the player 2 lose the game and a message
                    // inform the correct number chosen by the player 1.

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Sorry you Lose !!\nThe number should be {Number}");
                        Console.WriteLine("Best luck next time");
                        Console.ReadKey();
                    }
                    attempts++;
                }
                while (attempts < 3);
                //Here the application asks the user if he wants to play again or closes the application.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to play again? (Y/N)");
                again = Console.ReadLine().ToLower();
                if (again != "y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Thanks for playing, GoodBye... =D");
                }
            }
        }
    }
}
