using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTOs
{
    // For creating a new board
    public class CreateBoardDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }

    // For updating a board
    public class UpdateBoardDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }

    // What we return when getting board info
    public class BoardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int TaskCount { get; set; }
        public int MemberCount { get; set; }
    }

    // Detailed board info including tasks
    public class BoardDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserDto Owner { get; set; }
        public List<TaskItemDTOs> Tasks { get; set; }
        public List<BoardMemberDto> Members { get; set; }
    }

    // Board member information
    public class BoardMemberDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public DateTime JoinedAt { get; set; }
    }

    // For adding a member to a board
    public class AddBoardMemberDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Role { get; set; } // "Viewer", "Member", or "Admin"
    }
}