/*1. Write a calculator program which performs all simple arithmetic operations. The number of inputs for addition and multiplication can be dynamic. All 4 operation addition, subtraction, multiplication and division methods should have the same name. */

using System;

namespace day6_1
{
    class Program
    {
        static int operation(int x, int y)
        {
            return x + y;
        }
        static double operation(double x, double y)
        {
            return x - y;
        }
        static float operation(float x, float y)
        {
            return x * y;
        }
        static float operation(float x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which operation do you want to perform (add/sub/mul/div) choose anyone option from this: ");
            var input = Console.ReadLine();
            Console.WriteLine("enter two number for {0}", input);


            if (input == "add")
            {
                var number1 = int.Parse(Console.ReadLine());

                var number2 = int.Parse(Console.ReadLine());
                var result = operation(number1, number2);
                Console.WriteLine(result);
            }
            else if (input == "sub")
            {
                var number1 = Convert.ToDouble(Console.ReadLine());
                var number2 = Convert.ToDouble(Console.ReadLine());
                var result = operation(number1, number2);
                Console.WriteLine(result);
            }
            else if (input == "mul")
            {
                var number1 = float.Parse(Console.ReadLine());
                float number2 = float.Parse(Console.ReadLine());
                var result = operation(number1, number2);
                Console.WriteLine(result);
            }
            else if (input == "div")
            {
                var number1 = float.Parse(Console.ReadLine());
                var number2 = Convert.ToInt32(Console.ReadLine());
                var result = operation(number1, number2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}
