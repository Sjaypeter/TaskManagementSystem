namespace TaskManagementSystem.Models
{
    public class TaskAssignment
    {
        public int Id { get; set; }
        public DateTime AssignedAt { get; set; }
        //Which task?
        public int TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        //Which user?
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
