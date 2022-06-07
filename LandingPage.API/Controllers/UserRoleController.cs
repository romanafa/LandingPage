using AutoMapper;
using LandingPage.API.Data;
using LandingPage.API.Models.User;
using LandingPage.API.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LandingPage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class UserRoleController : ControllerBase
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper mapper;
        private readonly ILogger<UserRoleController> logger;

        public UserRoleController(RoleManager<ApplicationRole> roleManager,
            IMapper mapper,
            ILogger<UserRoleController> logger)
        {
            _roleManager = roleManager;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        [Route("Roles")]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetAllRoles()
        {
            if (_roleManager.Roles == null)
            {
                logger.LogWarning($"Data not found in {nameof(GetAllRoles)}");
                return NotFound();
            }
            try
            {
                var roles = await _roleManager.Roles.ToListAsync();
                var roleDtos = mapper.Map<IEnumerable<RoleDto>>(roles);

                return Ok(roleDtos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetAllRoles)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }


        //var user = await _context.Users
        //        .Include(ur => ur.UserRoles)
        //        .ThenInclude(r => r.Role)
        //        .Where(x => x.Id == id)
        //        .FirstOrDefaultAsync();
        ////.FindAsync(id);

        //var userRoleId = user.Roles.SingleOrDefault().Id;
        //var userRoleName = await _userManager.GetRolesAsync(user).ToList();
        //var newRole = _roleManager.FindByIdAsync(userDto.RoleId);

        //    if(userRoleId != userDto.RoleId)
        //    {
        //        _userManager.RemoveFromRoleAsync(user, userRoleName);
        //        await _userManager.AddToRoleAsync(user, newRole.Name);
    }
}

