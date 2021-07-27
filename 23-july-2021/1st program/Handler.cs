using System;

namespace Day15_1
{
    class Handler
    {



        //1. define a delegate
        //2. define an event based on that delegate
        //3. raise event

        //to find out white space


        public delegate void StringMethod();
        public event StringMethod MyEvent;
        public void WhiteSpace()
        {
            Console.WriteLine("enter a string with white space: ");
            var str = Console.ReadLine();
            var string1 = str;
            if (string1.Contains(" ")) ;
            var newString = string1.Replace(" ", "_");
            Console.WriteLine(newString);
            Console.WriteLine();

            MyEvent();
        }
        //string reverse
        public void ReverseString()
        {
            //for reversestring
            Console.WriteLine("enter a string to print reverse string: ");
            var str = Console.ReadLine();

            var length = str.Length;
            for (int i = 1; i <= length; i++)
            {
                Console.Write(str[length - i]);
            }
            Console.WriteLine();

            MyEvent();

        }
        //find the character and number of occurrence in a string /  text 
        public void OccurenceMethod()
        {
            Console.WriteLine("enter a string to find the occurence of the character: ");
            var str = Console.ReadLine();
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
            Console.WriteLine();

            MyEvent();

        }


        //joining multiple string
        public void JoinMultipleString()
        {
            Console.WriteLine("Enter first string for join operation: ");
            var str1 = Console.ReadLine();
            Console.WriteLine("Enter first string for join operation: ");
            var str2 = Console.ReadLine();
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine();
            MyEvent();

        }

    }
}
