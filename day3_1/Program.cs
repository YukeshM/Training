using System;

namespace day3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            int[] repeatedNumbers = new int[1];
            Console.WriteLine("Enter how many values do you want to store in a array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter {count}  values: "); 
            for (int i = 0; i < count; i++)
            {
                numbers[i] =Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<count; i++)
            {
                for(int j = i+1; j < count; j++)
                {
                    if (numbers[i] == numbers[j] )
                        Console.WriteLine("Repeated values are: {0}", numbers[j]);
                }
            }
        }


    }
 }

