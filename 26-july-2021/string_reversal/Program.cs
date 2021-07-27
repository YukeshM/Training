using System;

namespace Day16_stringReversal
{
    class Program
    {
        static string ReversalString(string sentence)
        {
            if (sentence.Length > 0)
            {
                return sentence[sentence.Length - 1] + ReversalString(sentence.Substring(0, sentence.Length - 1));
            }
            else
            {
                return sentence;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence for reverse string: ");
            var sentence = Console.ReadLine();
            var reverseString = ReversalString(sentence);
            Console.WriteLine(reverseString);
        }
    }
}
