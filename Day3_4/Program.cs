using System;

namespace Day3_4
{
    class Program
    {
        enum Landscape
        {
            width = 10, 
            height = 8
        }
        enum Portrait
        {
            width = 8, 
            height = 10
        }
        static void Main(string[] args)
        {
            int lWidth =  (int)Landscape.width;
            int lHeight = (int)Landscape.height;
            int pWidth = (int)Portrait.width;
            int pHeight = (int)Portrait.height;
            Console.WriteLine("Enter the width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());
            var landscape = (width == lWidth && height == lHeight) ? "landscape image" : "not a landscape image";
            Console.WriteLine(landscape);
            var portrait = (width == pWidth && height == pHeight) ? "portrait image" : "not a portrait image";
            Console.WriteLine(portrait);
        }
    }
}
