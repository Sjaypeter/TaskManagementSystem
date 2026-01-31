namespace TaskManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }

        //one user can have many boards
        public ICollection<Board> Boards { get; set; }

        //One user can be assigned to many tasks

        public ICollection<TaskAssignment> TaskAssignments { get; set; }

        //One user can make many comments
        public ICollection<Comment> Comments { get; set; }


    }
}
