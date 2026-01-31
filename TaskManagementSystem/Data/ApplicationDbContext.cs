using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata; 
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet represents a table in the database
        public DbSet<User> Users { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
        public DbSet<BoardMember> BoardMembers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FileAttachment> FileAttachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints

            // User -> Boards (one-to-many)
            modelBuilder.Entity<Board>()
                .HasOne(b => b.Owner)
                .WithMany(u => u.Boards)
                .HasForeignKey(b => b.OwnerId)
                .OnDelete(DeleteBehavior.Restrict); // Don't delete boards if user is deleted

            // Board -> Tasks (one-to-many)
            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoardId)
                .OnDelete(DeleteBehavior.Cascade); // Delete tasks if board is deleted

            // TaskAssignment -> Task (many-to-one)
            modelBuilder.Entity<TaskAssignment>()
                .HasOne(ta => ta.TaskItem)
                .WithMany(t => t.TaskAssignments)
                .HasForeignKey(ta => ta.TaskItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // TaskAssignment -> User (many-to-one)
            modelBuilder.Entity<TaskAssignment>()
                .HasOne(ta => ta.User)
                .WithMany(u => u.TaskAssignments)
                .HasForeignKey(ta => ta.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Set default values
            modelBuilder.Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Board>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<TaskItem>()
                .Property(t => t.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}