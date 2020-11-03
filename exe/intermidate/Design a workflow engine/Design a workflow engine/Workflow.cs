using System.Collections.Generic;

namespace Design_a_workflow_engine
{
    public class Workflow : IWorkflow
    {

        private readonly IList<ITask> _workflow;

        public Workflow()
        {
            _workflow = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _workflow.Add(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
           return _workflow;
        }

        public void Remove(ITask task)
        {
            _workflow.Remove(task);
        }
    }
}
