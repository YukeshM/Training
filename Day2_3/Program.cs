using System;

namespace Day2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Id, Name, Salary;
            Console.WriteLine("Enter your id: ");
            Id = Console.ReadLine();
            Console.WriteLine("Enter your Name: ");
            Name = Console.ReadLine(); 
            Console.WriteLine("Enter your Salary: ");
            Salary = Console.ReadLine();
            Console.WriteLine("your details:");
            Console.WriteLine(Convert.ToInt32(Id));//converts string to int
            Console.WriteLine(Name);
            Console.WriteLine(Convert.ToInt64(Salary));//converts string to long
        }
    }
}
