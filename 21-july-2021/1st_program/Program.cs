//1.  Generics
//Create your own  Dictionary which takes key , value pairs of type Generics. 
//Support methods like  Add, Remove and Sort.  Try this out on various user defined types. 


using System;
using System.Collections.Generic;

namespace Day13_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //to store int and string in the dictionary using generic
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(1, "kamal");
            myDict.Add(2, "hassan");
            myDict.Add(3, "nayagan");
            myDict.Add(4, "maganadhi");

            foreach (KeyValuePair<int, string> ele in myDict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();

            //removing a element
            myDict.Remove(1);
            foreach (KeyValuePair<int, string> ele in myDict)
            {
                Console.WriteLine("Number: {0} Name:{1}", ele.Key, ele.Value);
            }
            Console.WriteLine();







            //clear


        }
    }
}
