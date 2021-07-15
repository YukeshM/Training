//Write a program to create a stopwatch in c# 


using System;
using System.Threading;
namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
        }
    }
}
