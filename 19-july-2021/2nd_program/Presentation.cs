// Exception handling

// Create two programs in your solution.
// One is a console application name it as presentation
// Another is a class library name it as Domain
// Ensure you use .NET 5.0 framework for both 
// In the library project, build the functionality to   search for a text occurrence in a string builder  Text program,  If the text is found, return the information or throw an exception
// example:  Text:  "This is my sample text occurance",   subtext:  "Sample text"  
// In the main program ,  collect the message  or the exception  and display it to the user.  
// The main program should send both the Big  text  and substring  to the domain / library.  


using Domain;
using System;
using System.Text;

namespace Day10_2_presentation
{
    class Presentation
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("This is my sample text occurance");
            string subText = "sample text";

            DomainClass domainClass = new DomainClass();
            try
            {
                Console.WriteLine(domainClass.FindString(stringBuilder, subText));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message + " " + e.StackTrace);
            }

        }
    }
}


//output
//The given sub string is in the string.
