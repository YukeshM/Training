/*2.Write a program which continuously takes input numbers from user. If user types “Quit” then exit.  Separate the duplicates and make a new list for unique numbers.
Example:  3, 2, 3, 1, 10, 1.  2 and 10 are unique
*/
using System;
using System.Collections.Generic;

namespace day5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new();
            List<int> duplicate = new();
            Console.WriteLine("Enter a number or enter \"quit\" to exit:");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit" || input == "QUIT")
                    break;
                numbers.Add(Int32.Parse(input));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicate.Add(numbers[j]);
                    }
                }
            }
            foreach (int number in numbers)
            {
                if (!duplicate.Contains(number))
                    Console.WriteLine(number);
            }
        }
    }
}
