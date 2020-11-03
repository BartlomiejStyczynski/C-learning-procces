using System;

namespace Design_a_workflow_engine
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email..");
        }
    }

}
