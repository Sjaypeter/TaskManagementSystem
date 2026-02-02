namespace TaskManagementSystem.DTOs
{
    public class FileAttachmentDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public string ContentType { get; set; }
        public DateTime UploadedAt { get; set; }
        public int TaskItemId { get; set; }
        public int UploadedByUserId { get; set; }
        public string UploadedByUsername { get; set; }
    }
}