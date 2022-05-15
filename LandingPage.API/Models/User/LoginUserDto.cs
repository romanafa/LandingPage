using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.User
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "E-post mangler")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Skriv inn passord")]
        public string Password { get; set; }
    }
}
