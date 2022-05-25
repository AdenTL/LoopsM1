using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_loops
{
    internal class Exercises
    {
        public static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // SOLUTION HERE

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //int i = 5;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE
            Console.WriteLine("Enter a number between 1-20");
            int userInput = Int32.Parse(Console.ReadLine());

            while (userInput >= 1 && userInput <= 20)
            {
                Console.WriteLine(userInput);
                userInput--;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // SOLUTION HERE
            
            for(int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");


            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.
            // SOLUTION HERE
            while(true)
            {
                int userInput = Int32.Parse(Console.ReadLine());              
                if (userInput % 3 != 0)
                {
                    Console.WriteLine("Try Again");
                }
                else if (userInput % 3 == 0)                        //how to not use break?
                {
                    Console.WriteLine("You Won!");
                    break;
                }
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
