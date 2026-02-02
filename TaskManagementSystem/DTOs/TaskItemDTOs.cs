using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Models;
using static TaskManagementSystem.Models.TaskItem;

namespace TaskManagementSystem.DTOs
{
    // For creating a new task
    public class CreateTaskDto
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime? DueDate { get; set; }

        [Required]
        public int BoardId { get; set; }
    }

    // For updating a task
    public class UpdateTaskDto
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public TaskItem.TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime? DueDate { get; set; }
    }

    // What we return when getting task info
    public class TaskItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public int AssignedUserCount { get; set; }
        public int CommentCount { get; set; }
        public int AttachmentCount { get; set; }
    }

    // Detailed task info with all related data
    public class TaskDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public List<UserDTOs> AssignedUsers { get; set; }
        public List<CommentDTOs> Comments { get; set; }
        public List<FileAttachmentDto> Attachments { get; set; }
    }

    // For assigning users to a task
    public class AssignUserDto
    {
        [Required]
        public int UserId { get; set; }
    }
}