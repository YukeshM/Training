using System;

namespace Day2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName;
            int num1, num2;
            Console.WriteLine("enter your first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("enter your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(FirstName == LastName)
            {
                Console.WriteLine("first name and last name are same.");
            }
            else if(num1 == num2)
            {
                Console.WriteLine("first and second number are same.");
            }
            else if(FirstName == LastName && num1 == num2)
            {
                Console.WriteLine("both names and numbers are same.");
            }
            else if(FirstName == LastName || num1 == num2)
            {
                Console.WriteLine("names or numbers is same.");
            }
            else
            {
                Console.WriteLine("nothing is same.");
            }



        }
    }
}
