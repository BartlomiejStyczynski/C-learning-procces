using System;

namespace Design_a_workflow_engine
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();

            workFlow.Add(new UploadAvideoToCloud());
            workFlow.Add(new NotifyAboutEncoding());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ProccessVideo());

            var workFlowEngine = new WorkflowEngine();

            workFlowEngine.Run(workFlow);



        }
    }
}
