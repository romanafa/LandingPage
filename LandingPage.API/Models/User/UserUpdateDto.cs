using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.User
{
    public class UserUpdateDto
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Brukernavn mangler")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "E-post mangler")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Førstenavn mangler")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Etternavn mangler")]
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string RoleId { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}
