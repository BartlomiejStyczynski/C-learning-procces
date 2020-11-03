using System.Collections.Generic;

namespace Design_a_workflow_engine
{
    public interface IWorkflow
    {
       public void Add(ITask task);
        public void Remove(ITask task);
        IEnumerable<ITask> GetTasks();




    }
}
