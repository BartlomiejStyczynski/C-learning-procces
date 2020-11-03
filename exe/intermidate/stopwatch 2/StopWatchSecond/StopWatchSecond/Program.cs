
//Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
//provide two methods: Start and Stop.We call the start method first, and the stop method next.
//Then we ask the stopwatch about the duration between start and stop. Duration should be a
//value in TimeSpan.Display the duration on the console. 
using System;

namespace StopWatchSecond
{

    public class StopWatch 
    {
        public DateTime StartStopwatch;
        public TimeSpan Duration;

        public void Start()
        {
            if (StartStopwatch != null)
                this.StartStopwatch = DateTime.Now;

            else
                throw new Exception("InvalidOperationException");
        }

        public void Stop()
        {
            
            this.Duration = DateTime.Now - StartStopwatch;
        }

        
            
    }

    class Program
    {
        static void Main(string[] args)
        {
           var newCOmming = new StopWatch();

            newCOmming.Start();

            newCOmming.Stop();

            Console.WriteLine(newCOmming.Duration);

        }
    }
}
