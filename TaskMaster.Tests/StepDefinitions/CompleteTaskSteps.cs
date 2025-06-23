using FluentAssertions;
using TechTalk.SpecFlow;
using TaskMaster.Services;
using System.Linq;

namespace TaskMaster.Tests.StepDefinitions
{
    [Binding]
    public class CompleteTaskSteps
    {
        private readonly TaskManager _taskManager = new();

        //The Step Definition for the first statement is there in AddTaskSteps.cs
        //The Step Definition for the second statement is there in DeleteTaskSteps.cs

        [When(@"I mark the task ""(.*)"" as complete")]
        public void WhenIMarkTheTaskAsComplete(string name) => _taskManager.CompleteTask(name);

        [Then(@"the task ""(.*)"" should be marked as complete")]
        public void ThenTheTaskShouldBeMarkedAsComplete(string name)
        {
            var task = _taskManager.GetAllTasks().FirstOrDefault(t => t.Name == name);
            task.Should().NotBeNull();
            task!.IsCompleted.Should().BeTrue();
        }
    }
}