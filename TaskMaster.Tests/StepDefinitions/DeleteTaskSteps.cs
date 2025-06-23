using FluentAssertions;
using TechTalk.SpecFlow;
using TaskMaster.Services;
using System.Linq;

namespace TaskMaster.Tests.StepDefinitions
{
    [Binding]
    public class DeleteTaskSteps
    {

        private readonly TaskContext _context;

        public DeleteTaskSteps(TaskContext context) => _context = context;

        //Didn't write the step definition for the first "Given the task list is empty" statment because one of the step definition files already contains it.
        //No duplicate step definitions. SpecFlow takes the SD for this one from the AddTaskSteps.cs file. We can refactor the common SD's in another file
        //and reuse them, or as a simple fix for instance here, delete it. 
        //Also using shared context here. 

        [Given(@"I add a task named ""(.*)""")]
        public void GivenIAddATaskNamed(string name) => _context.TaskManager.AddTask(name);

        [When(@"I delete the task named ""(.*)""")]
        public void WhenIDeleteTheTaskNamed(string name) => _context.TaskManager.DeleteTask(name);

        [Then(@"the task list should not contain ""(.*)""")]
        public void ThenTheTaskListShouldNotContain(string name)
        {
            var tasks = _context.TaskManager.GetAllTasks();
            tasks.Any(t => t.Name == name).Should().BeFalse();
        }
    }
}