using FluentAssertions;
using TechTalk.SpecFlow;
using TaskMaster.Services;

namespace TaskMaster.Tests.StepDefinitions
{
    [Binding]
    public class AddTaskSteps
    {
        private readonly TaskContext _context;

        public AddTaskSteps(TaskContext context) => _context = context; 

        [Given("the task list is empty")]
        public void GivenTheTaskListIsEmpty()
        {
            _context.TaskManager.ClearTasks();
        }

        [When(@"I add a task named ""(.*)""")]
        public void WhenIAddATaskNamed(string taskName)
        {
            _context.TaskManager.AddTask(taskName);
        }

        [Then(@"the task list should contain ""(.*)""")]
        public void ThenTheTaskListShouldContain(string taskName)
        {
            var tasks = _context.TaskManager.GetAllTasks();
            tasks.Any(t => t.Name == taskName).Should().BeTrue();
        }

    }
}