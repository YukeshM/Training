using System;

namespace Day3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName, stateName;
            Console.WriteLine("Enter country name: ");
            countryName =Console.ReadLine();
            Console.WriteLine("Enter state name: ");
            stateName = Console.ReadLine();
            countryName = countryName.ToUpper();
            stateName = stateName.ToUpper();
            var result = (countryName == "INDIA" && stateName == "KERALA") ? "true" : "false";
            Console.WriteLine(result);
        }
    }
}
