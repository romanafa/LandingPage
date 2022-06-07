using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.User
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
