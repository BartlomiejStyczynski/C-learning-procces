using System;

namespace EventsAndDelegates
{
    partial class Program
    {
        public class MassageService
        {
            public void OnVideoEncoded(object source, VideoEventArgs args) 
            {
                Console.WriteLine("Sending a text msg..." + args.Video.Title);
            }

        }
    }

}
