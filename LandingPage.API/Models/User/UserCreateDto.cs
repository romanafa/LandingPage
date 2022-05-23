using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.User
{
    public class UserCreateDto : LoginUserDto
    {   
        [Required(ErrorMessage = "Førstenavn mangler")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Etternavn mangler")]
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
