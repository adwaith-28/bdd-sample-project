using FluentAssertions;
using TechTalk.SpecFlow;
using TaskMaster.Services;
using System.Linq;

namespace TaskMaster.Tests.StepDefinitions
{
    [Binding]
    public class CompleteTaskSteps
    {

        private readonly TaskContext _context;

        public CompleteTaskSteps(TaskContext context) => _context = context;

        //The Step Definition for the first statement is there in AddTaskSteps.cs
        //The Step Definition for the second statement is there in DeleteTaskSteps.cs

        [When(@"I mark the task ""(.*)"" as complete")]
        public void WhenIMarkTheTaskAsComplete(string name) => _context.TaskManager.CompleteTask(name);

        [Then(@"the task ""(.*)"" should be marked as complete")]
        public void ThenTheTaskShouldBeMarkedAsComplete(string name)
        {
            var task = _context.TaskManager.GetAllTasks().FirstOrDefault(t => t.Name == name);
            task.Should().NotBeNull();
            task!.IsCompleted.Should().BeTrue();
        }
    }
}