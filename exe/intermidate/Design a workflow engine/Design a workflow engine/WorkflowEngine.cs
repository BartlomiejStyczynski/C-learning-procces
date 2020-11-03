using System.Collections;
using System.Collections.Generic;

namespace Design_a_workflow_engine
{
    public class WorkflowEngine
    { 

        public void Run(IWorkflow workflow)
        {
            foreach (var task in workflow.GetTasks())
            {
                task.Execute();
            }
            
        }

    }
}
