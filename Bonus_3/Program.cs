using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool run = true;

            Intro();

            do
            {
                RangeFind();

                run = Continue();

            }while (run == true);
        }

        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");
            Console.ResetColor();

            Console.WriteLine("I am thinking of a number between 1 and 100: \n");
            Console.Write("Try to guess: ");

        }

        public static int GetValidInteger()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Not a valid number");
            }

            while (num > 100 || num < 0)
            {
                Console.Write("Please enter an integer between 0 and 100. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out num)) ;
            }
            return (num);
        }

        public static int RangeFind()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            bool x = true;
            int i = 0;
            
            do {
                int input = GetValidInteger();
                i++;

                if (input < num && Math.Abs(input - num) <= 10)
                {
                    Console.WriteLine("\nToo low!");
                }
                else if (input < num && Math.Abs(input - num) > 10)
                        {
                            Console.WriteLine("\nWay Too low!");
                        }
                if (input > num && Math.Abs(input - num) <= 10)
                {
                    Console.WriteLine("\nToo high!");
                }
                else if(input > num && Math.Abs(input - num) > 10)
                        {
                            Console.WriteLine("\nWay Too high!");
                        }

                if (input != num)
                {
                    Console.Write("\n\nGuess again:");  
                }

                else if (input == num)
                {
                    Console.WriteLine("\nYou got it in " + i + " tries!");

                    if (i <= 3)
                        Console.WriteLine("\nLucky guesses!");

                    if (i >= 4 && i <= 10)
                        Console.WriteLine("\nSeems about right!");

                    if (i > 10)
                        Console.WriteLine("\nAre you even trying?");
                    x = false;
                }
            }while (x == true) ;
                return num;
            }

        public static bool Continue()
        {
            string conf;
            bool check = true;
            bool run = true;
            
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to play again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    Intro();
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");

                    run = false;
                    check = false;
                }
            } while (check == true);
            return run;
        }
  }
}
   

