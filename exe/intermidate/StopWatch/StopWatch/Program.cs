using System;

namespace StopWatch
{


    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;

            while (end)
            {
                    
                    var stopwatch = new Stopwatch();

                Console.WriteLine("Type start to start the stop watch");
                    var inputStart = Console.ReadLine().ToLower();
                    stopwatch.Start(inputStart);


                    var inputStop = Console.ReadLine().ToLower();
                    stopwatch.Stop(inputStop);

                    Console.WriteLine(stopwatch.Interval().ToString(@"hh\:mm\:ss"));
                    Console.WriteLine("Press enter or type exit to exit or continue to start again");
                
                
                var inputAgain = Console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(inputAgain) || inputAgain == "exit")
                    end = false;
               
                else
                    Console.Clear();
            }



            
        }
    }
}
