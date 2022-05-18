using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.Group
{
    public class GroupUpdateDto
    {
        public int GroupId { get; set; }
        [Required(ErrorMessage = "Gruppenavn mangler")]
        public string GroupName { get; set; }
        [Required]
        public bool IsActiveGroup { get; set; }
        public string? UserId { get; set; }
        //public UserDto? ApplicationUser { get; set; }
    }
}
