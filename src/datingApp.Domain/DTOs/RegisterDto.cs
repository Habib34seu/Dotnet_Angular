using System.ComponentModel.DataAnnotations;

namespace datingApp.Domain.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }    

        [Required]
        public string Password { get; set; }
    }
}