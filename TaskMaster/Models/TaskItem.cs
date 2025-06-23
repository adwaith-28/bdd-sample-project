namespace TaskMaster.Models
{
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string name)
        {
            Name = name;
            IsCompleted = false;
        }
    }
}