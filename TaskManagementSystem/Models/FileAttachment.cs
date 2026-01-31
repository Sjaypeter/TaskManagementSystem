namespace TaskManagementSystem.Models
{
    public class FileAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; } // Where the file is stored
        public long FileSize { get; set; } // Size in bytes
        public string ContentType { get; set; } // image/png, application/pdf, etc.
        public DateTime UploadedAt { get; set; }

        // Which task does this belong to?
        public int TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        // Who uploaded it?
        public int UploadedByUserId { get; set; }
        public User UploadedBy { get; set; }
    }
}