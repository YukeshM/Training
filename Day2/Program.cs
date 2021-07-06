using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rgb = 250;
            sbyte random = 126;
            int num1 = 423878395;
            uint num2 = 89328943;
            short num3 = 32380;
            ushort num4 = 39203;
            long num5 = 954389046196770;
            ulong num6 = 90339032490340009;
            float num7 = 8.92489032f;
            double num8 = 98023073409320d;
            bool condition = true; 
            char letter = 'y';
            object word = "hello world";
            string name = "yukesh";
            Console.WriteLine("byte: {0}", rgb);
            Console.WriteLine("sbyte: {0}", random);
            Console.WriteLine("int: {0}", num1);
            Console.WriteLine("uint: {0}", num2);
            Console.WriteLine("short: {0}", num3);
            Console.WriteLine("ushort: {0}", num4);
            Console.WriteLine("long: {0}", num5);
            Console.WriteLine("ulong: {0}", num6);
            Console.WriteLine("float: {0}", num7);
            Console.WriteLine("double: {0}", num8);
            Console.WriteLine("boolean: {0}", condition);
            Console.WriteLine("char: {0}", letter);
            Console.WriteLine("string: {0}", name);
            Console.WriteLine("object: {0}",word);
        }
    }
}
