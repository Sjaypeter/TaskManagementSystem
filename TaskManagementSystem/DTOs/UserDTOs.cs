using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTOs
{
    public class RegisterDTOs
    {
        [Required]
        [StringLength(50, MinimumLength =3)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength (100, MinimumLength = 6)]
        public string Password { get; set; }

    }

    public class LoginDTOs
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }

    public class AuthResponseDTOs
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

    }

    public class UserDTOs
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }





}
