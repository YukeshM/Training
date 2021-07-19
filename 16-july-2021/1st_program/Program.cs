//1. Method Hiding 

//Create a Base Class with a method with the name WriteNum and display an integer.
//Create another virtual method WriteStr and display some string.
//Create a Derived class and create a hidden method by name WriteNum and override the method WriteStr. 
//Create Objects -
// -objectA  of type base class
//-objectB of type  base class but downcasted to the derived class
//-objectC of type derived class
//Display the methods from all 3 objects


using System;

namespace Day10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From base class.");
            //object of type base class
            MethodHiding baseClass = new MethodHiding();
            baseClass.WriteNum();
            baseClass.WriteString();

            Console.WriteLine("\n");
            Console.WriteLine("Output for downcasting: ");
            //object of type  base class but downcasted to the derived class
            MethodHiding methodHiding = new DerivedClass();
            methodHiding.WriteNum();
            methodHiding.WriteString();
            methodHiding.WriteNum();
            Console.WriteLine("\n");

            //object of type  derived class but upcasted to the base class
            Console.WriteLine("Output for upcasting:");
            DerivedClass derivedClass = (DerivedClass)new();
            derivedClass.WriteNum();
            derivedClass.WriteString();
            Console.WriteLine("\n");

            Console.WriteLine("From derived class.");
            //object type in derived class
            DerivedClass derivedClass1 = new DerivedClass();
            derivedClass.WriteNum();
            derivedClass.WriteString();
        }
    }
}
