using System;

namespace Day16_fibonacci
{
    class Program
    {
        static int Fibo(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return Fibo(num - 1) + Fibo(num - 2);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter the length of the fibonacci series: ");
            int fibonacci = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < fibonacci; i++)
            {
                Console.Write("{0} ", Fibo(i));
            }
        }

    }
}
