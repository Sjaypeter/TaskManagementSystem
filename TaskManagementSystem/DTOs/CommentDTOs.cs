using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTOs
{
    // For creating a comment
    public class CreateCommentDto
    {
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Content { get; set; }

        [Required]
        public int TaskItemId { get; set; }
    }

    // For updating a comment
    public class UpdateCommentDto
    {
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Content { get; set; }
    }

    // What we return
    public class CommentDTOs
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int TaskItemId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}