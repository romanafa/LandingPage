using LandingPage.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LandingPage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUserRoles()
        //{
        //    var users = _userManager.Users
        //        .Include(u => u.Roles).Include(u => u.Claims);

        //    var result = new
        //    {

        //    }
        //}

        //private async Task<List<string>> GetUserRoles(ApplicationUser user)
        //{
        //    return new List<string>(await _userManager.GetRolesAsync(user));
        //}
    }
}
