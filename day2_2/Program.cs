using System;

namespace day2_2
{
    class Program
    {
        //method for addition:
        static void Add(int x, decimal y)
        {
            int sum =(int) (x + y);
            Console.WriteLine($"sum of {x} and {y} is : {sum}");
        }
        //method for division:
        static void Div(decimal x, int y)
        {
            decimal div = (x / y);
            Console.WriteLine("div of "+ x + " " + "and" +" "+ y +"is :" + div);
        }
        //method for multiplication:
        static void Mul(float x, float y)
        {
            float mul = (x * y);
            Console.WriteLine("mul of {0} and {1} is : {2}", x, y, mul);
        }
        static void Main(string[] args)
        {
            
            string condition, add, mul, div;
            Console.WriteLine("what operation do you want to perform, choose anyone from the option(add,mul,div)");
            condition = Console.ReadLine();
            if(condition == "add")
            {
                int num1;
                decimal num2;
                Console.WriteLine("enter an integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter an decimal: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                Add(num1, num2);
            }
            else if(condition == "div")
            {
                decimal num1;
                int num2;
                Console.WriteLine("enter an decimal: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter an integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Div(num1, num2);

            }
            else if(condition == "mul")
            {
                float num1, num2;
                Console.WriteLine("enter a float number: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("enter another float number: ");
                num2 = float.Parse(Console.ReadLine());
                Mul(num1, num2);
            }
            else 
            {
                Console.WriteLine("operation not found! enter from the option");
            }
        }
    }
}
