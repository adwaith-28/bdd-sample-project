using TaskMaster.Services;

namespace TaskMaster.Tests.StepDefinitions
{
    public class TaskContext
    {
        public TaskManager TaskManager { get; } = new TaskManager();
    }
}