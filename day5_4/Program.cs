/*4. Ask the user to enter the time in 24 hours format (eg: 17:00), If the time is between 00:00  and 23:59  then display as valid time else display as invalid time. */

using System;

namespace day5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in 24 hour format(HH:MM:SS): ");
            DateTime time = new DateTime();
            var timeInput = Console.ReadLine();
            if (DateTime.TryParse(timeInput, out time) == true)
            {
                Console.WriteLine("valid time.");
            }
            else
            {
                Console.WriteLine("invalid time.");
            }

        }
    }
}
