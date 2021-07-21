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