using System;
using TaskMaster.Services;

class Program
{
    static void Main()
    {
        var manager = new TaskMaster.Services.TaskManager();
        manager.AddTask("Buy Milk");

        foreach (var task in manager.GetAllTasks())
        {
            Console.WriteLine($"- {task.Name} (Done: {task.IsCompleted})");
        }
    }
}