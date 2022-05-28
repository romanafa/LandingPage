using AutoMapper;
using LandingPage.API.Data;
using LandingPage.API.Models.User;
using LandingPage.API.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LandingPage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class UsersController : ControllerBase
    {
        private readonly AthenaPayLandingPageDbContext _context;
        private readonly IMapper mapper;
        private readonly ILogger<UsersController> logger;

        public UsersController(AthenaPayLandingPageDbContext context, IMapper mapper, ILogger<UsersController> logger)
        {
            _context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadOnlyDto>>> GetUsers()
        {
            if (_context.Users == null)
            {
                logger.LogWarning($"Data not found in {nameof(GetUsers)}");
                return NotFound();
            }

            try
            {
                var users = await _context.Users
                    .Include(ur => ur.UserRoles)
                    .ThenInclude(r => r.Role)
                    .ToListAsync();
                var userDtos = mapper.Map<IEnumerable<UserReadOnlyDto>>(users);
                return Ok(userDtos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetUsers)}");
                return StatusCode(500, Messages.Error500Message);
            }


        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserReadOnlyDto>> GetUser(string id)
        {
            if (_context.Users == null)
            {
                logger.LogWarning($"Data not found in {nameof(GetUser)}");
                return NotFound();
            }

            try
            {
                var user = await _context.Users
                    .Include(ur => ur.UserRoles)
                    .ThenInclude(r => r.Role)
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    logger.LogWarning($"No data found in {nameof(GetUser)} - ID: {id}");
                    return NotFound();
                }

                var userDto = mapper.Map<UserReadOnlyDto>(user);
                return Ok(userDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetUser)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, UserUpdateDto userDto)
        {
            if (id != userDto.Id)
            {
                logger.LogWarning($"Invalid ID in {nameof(PutUser)} - ID: {id}");
                return BadRequest();
            }

            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                logger.LogWarning($"{nameof(User)} not found in  {nameof(PutUser)} - ID: {id}");
                return NotFound();
            }

            mapper.Map(userDto, user);

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!UserExists(id))
                {
                    logger.LogWarning($"Data not found in {nameof(PutUser)}");
                    return NotFound();
                }
                else
                {
                    logger.LogError(ex, $"Error: PUT in {nameof(PutUser)}");
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<UserCreateDto>> PostUser(UserCreateDto userDto)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            try
            {
                var user = mapper.Map<ApplicationUser>(userDto);
                user.UserName = userDto.Email;
                user.PasswordHash = hasher.HashPassword(null, userDto.Password);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUser", new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: POST in {nameof(PostUser)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    logger.LogWarning($"{nameof(User)} not found in {nameof(DeleteUser)} - ID: {id}");
                    return NotFound();
                }

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: DELETE in {nameof(DeleteUser)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        private bool UserExists(string id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
