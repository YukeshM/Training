using System;

namespace MyFirstProgram
{
  //2a) take input from user and display
    class program
    {
        static void Main(string[] args)
        {
        string firstName, lastName;
        firstName = "kamal";
        lastName = "hassan";
        Console.WriteLine("hi {0} {1}. ", firstName, lastName);
        }

    //2b) firstName and lastName input from command line argument
    class Program
    {
        static void Main()
        {
        string firstName, lastName;
        Console.WriteLine("enter your first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("enter your last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine("hi {0} {1}", firstName, lastName);
        }
    }

    // 3) sum of two numbers
    class program
    {
        static void Main()
    {
        int num1, num2, sum;
        Console.WriteLine("enter two numbers for addition: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine("sum of {0} and {1} is {2}.", num1, num2, sum);
    }
    }
    
    //4) division of two numbers
    class program
    {
        static void Main()
        {
            int num1, num2, div;
            Console.WriteLine("enter two numbers for division: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            div = num1 / num2;
            Console.WriteLine("sum of {0} and {1} is {2}.", num1, num2, div);
        }

    }

// strings
class program
{
    static void Main()
        {
            string firstName, lastName;
            firstName = "kamal";
            lastName = "hassan";
            Console.WriteLine($"My name is {firstName} {lastName}");
            Console.WriteLine("My name is "+ firstName+ lastName);
            Console.WriteLine("hi {0} {1}. ", firstName, lastName);
        }
}
}