using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.User
{
    public class UserDto : LoginUserDto
    {   
        public string Id { get; set; }
        [Required(ErrorMessage = "Førstenavn mangler")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Etternavn mangler")]
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
