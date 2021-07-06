using System;

namespace Day2_5
{
    class Program
    {
        //method for addition:
        static void Add(int x, int y)
        {
            int sum = (x + y);
            Console.WriteLine($"sum of {x} and {y} is : {sum}");
        }
        //method for subtraction:
        static void Sub(int x, int y)
        {
            int sub = (x - y);
            Console.WriteLine($"sum of {x} and {y} is : {sub}");
        }
        //method for division:
        static void Div(decimal x, decimal y)
        {
            decimal div = (x / y);
            Console.WriteLine("div of " + x + " " + "and" + " " + y + "is :" + div);
        }
        //method for multiplication:
        static void Mul(float x, float y)
        {
            float mul = (x * y);
            Console.WriteLine("mul of {0} and {1} is : {2}", x, y, mul);
        }
        static void Main(string[] args) {
            int num1, num2;
            Console.WriteLine("enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            string condition, add, sub, mul, div;
            Console.WriteLine("what operation do you want to perform, choose anyone from the option(add,sub,mul,div)");
            condition = Console.ReadLine();
            if(condition == "add"){
                Add(num1, num2);
            }
            else if(condition == "sub")
            {
                Sub(num1, num2);
            }
            else if (condition == "mul")
            {
                Mul(num1, num2);
            }
            else if (condition == "div")
            {
                Div(num1, num2);
            }
            else 
            {
                Console.WriteLine("operation not found! enter from the option");
            }
        }
      
    }
}
