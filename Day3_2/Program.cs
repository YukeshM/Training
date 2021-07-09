using System;

namespace Day3_2
{
    class Customer
    {
        string customerName;
        int customerId;
        public void PlaceOrder()
        {
            Console.WriteLine("I just got executed from PlaceOrder.");
        }
        static void GetCustomerTimeZone()
        {
            Console.WriteLine("I just got executed from GetCustomerTimeZone.");

        }

        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.customerName = "Ben Tennyson";
            customer.customerId = 10;
            customer.PlaceOrder();
            //customer.GetCustomerTimeZone();
            var name = customer.customerName;
            var id = customer.customerId;
            customer.customerName = "Gwen";
            Console.WriteLine($"customer name is: {customer.customerName}");
            Console.WriteLine($"customer id is: {customer.customerId}");
        }
    }
}
