using System;

namespace Design_a_workflow_engine
{
    public class NotifyAboutEncoding : ITask
    { 
        public void Execute()
        {
            Console.WriteLine("Sending a notification about the encrytpion");
        }
    }
}
