using System.Collections.Generic;
using System.Linq;
using TaskMaster.Models;

namespace TaskMaster.Services
{
    public class TaskManager
    {
        private readonly List<TaskItem> _tasks = new();

        public void AddTask(string name)
        {
            _tasks.Add(new TaskItem(name));
        }

        public void CompleteTask(string name)
        {
            var task = _tasks.FirstOrDefault(t => t.Name == name);
            if(task != null)
            {
                task.IsCompleted = true;
            }
        }

        public void DeleteTask(string name)
        {
            var task = _tasks.FirstOrDefault(t => t.Name == name);
            if(task != null)
            {
                _tasks.Remove(task);
            }
        }

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public void ClearTasks()
        {
            _tasks.Clear();
        }
    }
}