using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncouder
    {
        // 1- define a delegate
        // 2- difne an event on the delegate
        // 3- raise the event

        public delegate void VideoEncoudedEvenHandler(object source, VideoEventArgs args);
        public event VideoEncoudedEvenHandler VideoEncoded;

        //Delegate class EvenHandler <- bez wysylania dodatkowych danych
        //EventHandler<TeventArgs>


        // public even EventHandler<VideoEventArgs> VideoEncoded;
        // to samo to tworzenie swoich customowych delegatow

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding the video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        //konwencja, zawsze protected virtual
        // zaczyna sie od On**
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }


    }
}
