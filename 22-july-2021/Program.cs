//1.Delegates

//Create multiple  string manipulation methods like
//a ) Removes white spaces with underscore 
//b)  String reverse 
//c)  join multiple strings 
//d)  find the character and number of occurrence in a string /  text 
//Try to access these methods using Delegate 


using System;

namespace Day13
{
    class Program
    {
        public delegate void StringMethod(string str);
        public delegate void JoinMethod(string str1, string str2);

        static void Main(string[] args)
        {
            Console.WriteLine("enter a string with white space");
            var str = Console.ReadLine();


            //for two strings
            //Console.WriteLine("Enter first string for join operation: ");
            //var str1 = Console.ReadLine();
            //Console.WriteLine("Enter first string for join operation: ");
            //var str2 = Console.ReadLine();

            StringMethod stringMethod1 = new StringMethod(WhiteSpace);
            stringMethod1 += ReverseString;
            stringMethod1 += OccurenceMethod;

            //for joining string
            //JoinMethod joinMethod = new JoinMethod(JoinMultipleString);
            stringMethod1.Invoke(str);
            //joinMethod.Invoke(str1,str2);
                        
        }
        //to find out white space
        public static void WhiteSpace(string str)
        {
            
            var string1 = str;
            if (string1.Contains(" "));
            var newString = string1.Replace(" ", "_");
            Console.WriteLine(newString);
        }

        //string reverse
        public static void ReverseString(string reverseString)
        {
            
            var length = reverseString.Length;
            for (int i = 1; i <= length; i++)
            {
                Console.Write(reverseString[length - i]);
            }

        }

        //joining multiple string
        public static void JoinMultipleString(string string1, string string2)
        {
            Console.WriteLine(string.Concat(string1, string2));

            
        }

        //find the character and number of occurrence in a string /  text 
        public static void OccurenceMethod(string str)
        {
            var count = 0;
            var occurence = 0;
            var character = ' ';
            Console.WriteLine("enter a character to find and number of occurrence in the {0} string.", str);
            var text = char.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        character = str[j];
                        occurence = count + 1;

                    }

                }

            }
            Console.WriteLine($"{character} exists {occurence} times in the {str}");
        }
    }
}

