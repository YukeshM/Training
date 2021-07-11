/*Write a program which asks the user to enter multiple names until you press the enter button  (a blank name). Store them in a List.
If the number of names are more than 2 then display a formatted string like name[0] , name[1] and others < name.count-2>  people  like your post! ,
If the number of names are two then display like name[0] and name[1] likes your post! , if there is only one name display name[0] likes your post  else  display blank line*/

using System;
using System.Collections.Generic;

namespace Day5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter multiple names: ");
            string[] names = new string[100];
            List<string> name = new();
            for (int i = 0; i < 100; i++)
            {
                names[i] = Console.ReadLine();
                var result = string.IsNullOrWhiteSpace(names[i]);
                if (result == true)
                {
                    break;
                }
                else
                {
                    string copiedNames = names[i];
                    name.Add(copiedNames);
                }

            }

            if (name.Count >= 3)
            {
                foreach (var item in name)
                {
                    Console.WriteLine($"{item} liked your post");
                }
            }
            else if (name.Count == 2)
            {
                foreach (var item in name)
                {
                    Console.WriteLine($"{item} likes your post");
                }
            }
            else if (name.Count == 1)
            {
                foreach (var item in name)
                {
                    Console.WriteLine($"{item} likes your post");
                }
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
