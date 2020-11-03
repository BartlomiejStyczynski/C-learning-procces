using System;

namespace EventsAndDelegates
{
    public class MailServide
    { 
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("An email was sent." + e.Video.Title);
        }

    }

}
