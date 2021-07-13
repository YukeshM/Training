/* A program to convert the decimal to DMS (GPS coordinates). Make use of all datatypes concepts and also use classes and methods as much as possible. Also learn an make use of Math Function, if required*/
using System;

namespace Day6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            int _degree = Decimal.ToInt32((number));
            //Console.WriteLine(_degree);
            decimal minute = number - _degree;
            decimal minutes = 60 * minute;
            int _minutes = Decimal.ToInt32(minutes);
            //Console.WriteLine(_minutes);
            decimal second = minutes - _minutes;
            decimal seconds = 60 * second;
            int _seconds = Decimal.ToInt32(seconds);
            //Console.WriteLine(_seconds);
            Console.WriteLine("For the decimal value: {0}, the DMS value is {1}degrees {2}minutes and {3}seconds", number, _degree, _minutes, _seconds);
        }
    }
}
