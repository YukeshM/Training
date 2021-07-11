/*3. I have a large text, but have to display only 20 characters of the text and display but ensure you won't break the word appearing in the end. So It can go a little beyond 20 characters ensuring we won't break the word. 
example:  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard
Output :   Lorem Ipsum is simply dummy*/

using System;

namespace day5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            char modifiedSentence;
            int whiteSpace;
            Console.WriteLine("Enter a sentence: ");
            sentence = Console.ReadLine();
            for (int i = 20; i < 30; i++)
            {
                whiteSpace = sentence.IndexOf(" ", i);
                if (whiteSpace >= 20)
                {
                    for (int j = 0; j < whiteSpace + 1; j++)
                    {
                        modifiedSentence = sentence[j];
                        Console.Write(modifiedSentence);
                    }
                }
                break;
            }


        }
    }
}
