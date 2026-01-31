namespace TaskManagementSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime ? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //Which task is this comment on
        public int TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        //who made the comment
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
