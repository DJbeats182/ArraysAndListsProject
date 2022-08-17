using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
           int[] myArray1 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var evens = new List<int>();
            var odds = new List<int>();
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            foreach (var item in myArray1)
            {
                if (item % 2 == 0)
                {
                    evens.Add(item);
                }
                else
                {
                    odds.Add(item);
                }
            }

            Console.WriteLine("Here are the Even numbers in myArray!\n");
            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("And here are the Odd numbers in myArray!\n");
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
