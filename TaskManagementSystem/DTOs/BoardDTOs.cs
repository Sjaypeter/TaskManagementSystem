using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTOs
{
    public class CreateBoardDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }


    }

    public class UpdateBoardDto 
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public string Description { get; set; }


    }

    public class BoardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set;

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int TaskCount { get; set; }
        public int MemberCount { get; set; }
    }

    public class BoardDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public string Owner { get; set; }

        public List<TaskItemDto> Tasks { get; set; }
        public List<BoardMemberDto> Members { get; set; }

    }
}
