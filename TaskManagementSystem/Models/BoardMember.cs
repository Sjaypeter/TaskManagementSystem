namespace TaskManagementSystem.Models
{
    public class BoardMember
    {
        public int Id { get; set; }

        public int BoardId { get; set; }
        public Board Board { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public BoardRole Role { get; set; } // Admin, Member, Viewer
        public DateTime JoinedAt { get; set; }
    }

    public enum BoardRole
    {
        Viewer = 0,   // Can only view
        Member = 1,   // Can create/edit tasks
        Admin = 2     // Can manage board and members
    }
}