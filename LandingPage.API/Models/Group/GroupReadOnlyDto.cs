namespace LandingPage.API.Models.Group
{
    public class GroupReadOnlyDto
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsActiveGroup { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
