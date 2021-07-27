//2.
//Create a console  program which has following classes
//- Customer (CustomerID, Name, Age, BloodGroup)
//-InsuranceDetails(InsuranceId, Validity, CustomerId, age)
//a) Medical Insurance(Premium amount, List of appointments completed)
//b) Life Insurance(Premium amount, Nominee, Maturity date)

//Methods can be
//1) Add customers 
//2) Add Insurance for both medical and Life 
//3) FindBloodGroup - which accepts the blood group as input and searches for customers with a condition - if they are attached to medical insurance their number of completed appointments should not exceed 2 and in general the insurer age should not exceed 60.


using System;
using System.Collections.Generic;

namespace Day15_2

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "virumandi", 45, "A+"));
            customers.Add(new Customer(2, "uththama villain", 60, "B+"));
            customers.Add(new Customer(3, "maganadhi", 33, "A-"));
            customers.Add(new Customer(4, "avvai shanmugi", 65, "A+"));

            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerBloodGroup);
            }

        }

    }
}
