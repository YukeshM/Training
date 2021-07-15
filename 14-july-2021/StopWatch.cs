using System;
using System.Threading;

namespace Day8
{
    public class StopWatch
    {

        public void Start()
        {
            if (running)
            {
                throw new InvalidOperationException();
            }
            running = true;
            start = DateTime.Now;
            Console.WriteLine("Start time: " + start.Hour + ":" + start.Minute + ":" + start.Second + ":" + start.Millisecond);

        }
        public void Stop()
        {
            Thread.Sleep(1000);
            stop = DateTime.Now;
            running = false;
            Console.WriteLine("Stop time: " + stop.Hour + ":" + stop.Minute + ":" + stop.Second + ":" + stop.Millisecond);
            TimeSpan duration = stop - start;
            Interval(duration);

        }
        public void Interval(TimeSpan duration)
        {
            Console.WriteLine("Interval:" + duration.Seconds + " " + "sec" + duration.Milliseconds + " " + "milliseconds");
        }
        public StopWatch()
        {
            start = new DateTime();
            stop = new DateTime();
            store = new Random();
            running = false;

        }
        public DateTime start;
        public DateTime stop;
        public Random store;
        public bool running;

    }
}
