using System;

namespace Design_a_workflow_engine
{
    public class UploadAvideoToCloud : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video to a cloud storage"); ;
        }
    }

}
