namespace TaskManagementSystem.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        //FOREIGNKEY- who created the board

        public int OwnerId { get; set; }
        public User Owner { get; set; }
        //One board has many tasks
        public ICollection<TaskItem> Items { get; set; }
        //one board can have many members
        public ICollection<BoardMember> BoardMembers { get; set; }
    }
}
