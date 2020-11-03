using System;

namespace Design_a_workflow_engine
{
    public class ProccessVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Proccessing the video");
        }
    }

}
