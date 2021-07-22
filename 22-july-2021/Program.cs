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
    public delegate void StringMethod();

    class Program
    {
        static void Main(string[] args)
        {
            StringMethod stringMethod1 = new StringMethod(WhiteSpace);
            StringMethod stringMethod2 = new StringMethod(ReverseString);
            StringMethod stringMethod3 = new StringMethod(JoinMultipleString);
            StringMethod stringMethod4 = new StringMethod(OccurenceMethod);


            //Program.WhiteSpace("kamal hassan");
            //Program.ReverseString("appu");
            //Program.JoinMultipleString();
            Program.OccurenceMethod();
        }
        //to find out white space
        public static void WhiteSpace()
        {
            Console.WriteLine("enter a string with white space");
            var str = Console.ReadLine();
            var string1 = str;
            if (string1.Contains(" ")) ;
            var newString = string1.Replace(" ", "_");
            Console.WriteLine(newString);
        }

        //string reverse
        public static void ReverseString()
        {
            Console.WriteLine("enter a string for reverse string: ");
            var reverseString = Console.ReadLine();
            var length = reverseString.Length;
            for (int i = 1; i <= length; i++)
            {
                Console.Write(reverseString[length - i]);
            }

        }

        //joining multiple string
        public static void JoinMultipleString()
        {
            string[] multiString = new String[10];
            Console.WriteLine("enter how much strings do you want to add: ");
            var length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("enter a string: ");
                multiString[i] = Console.ReadLine();

            }
            foreach (var item in multiString)
            {
                Console.Write(item + " ");
            }
        }

        //find the character and number of occurrence in a string /  text 
        public static void OccurenceMethod()
        {
            var count = 0;
            var occurence = 0;
            var character = ' ';
            Console.WriteLine("enter a string: ");
            var str = Console.ReadLine();
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
