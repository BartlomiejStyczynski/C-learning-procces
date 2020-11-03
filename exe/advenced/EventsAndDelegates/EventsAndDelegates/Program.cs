namespace EventsAndDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var newVideo = new Video() { Title = "Kamikaze"};
            var newEncoder = new VideoEncouder();//publisher
            var mailService = new MailServide();//subscriber
            var massageService = new MassageService(); // subcriber
            newEncoder.VideoEncoded += mailService.OnVideoEncoded;
            newEncoder.VideoEncoded += mailService.OnVideoEncoded;//pointer to a method, just name
            

            newEncoder.Encode(newVideo);
            
            
        }
    }

}
