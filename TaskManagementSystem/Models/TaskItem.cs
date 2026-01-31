namespace TaskManagementSystem.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime ? DueDate { get; set; }

        public int BoardId { get; set; }
        public Board Board { get; set; }

        public ICollection<TaskAssignment> TaskAssignments { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<FileAttachment> FileAttachments { get; set; }

        public enum TaskStatus
        {
            ToDo = 0,
            InProgress = 1,
            Done = 2
        }
        public enum TaskPriority
        {
            Low = 0,
            Medium = 1,
            High = 2
        }

    }
}
