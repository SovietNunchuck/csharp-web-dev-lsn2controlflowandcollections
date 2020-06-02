using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> addThis = new List<int> { 4, 2, 44, 6, 2, 34, 3, 7, 2, 43 };
            Console.WriteLine(FindSum(addThis));

            
            Console.WriteLine("This program allows you to search for strings of a certain length within our list.\nPlease enter a character length: ");
            int choice = int.Parse(Console.ReadLine());
            PrintFivers(choice);
        }

        static int FindSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        //THE FOLLOWING METHOD IS NAMED "PRINTFIVERS" BECAUSE IT WAS ORIGINALLY USED TO PRINT STRINGS OF A FIXED LENGTH (5).  IT HAS BEEN MODIFIED TO PRINT STRINGS OF A LENGTH SPECIFIED BY USER INPUT.
        static void PrintFivers(int num)
        {
            List<string> words = new List<string> { "fiver", "not a fiver", "horse", "bravo", "eleven" };

            foreach (string word in words)
            {
                if (word.Length == num)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
