using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.Group
{
    public class GroupCreateDto
    {
        [Required(ErrorMessage = "Gruppenavn mangler")]
        public string GroupName { get; set; }
        [Required]
        public bool IsActiveGroup { get; set; }
    }
}
