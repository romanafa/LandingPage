using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandingPage.API.Data;
using LandingPage.API.Models.Group;
using AutoMapper;
using LandingPage.API.Static;

namespace LandingPage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly AthenaPayLandingPageDbContext _context;
        private readonly IMapper mapper;
        private readonly ILogger<GroupsController> logger;

        public GroupsController(AthenaPayLandingPageDbContext context, IMapper mapper, ILogger<GroupsController> logger)
        {
            _context = context;
            this.mapper=mapper;
            this.logger=logger;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupReadOnlyDto>>> GetGroups()
        {
            if (_context.Groups == null)
            {
                return NotFound();
            }

            try
            {
                var groups = await _context.Groups.ToListAsync();
                var groupDtos = mapper.Map<IEnumerable<GroupReadOnlyDto>>(groups);
                return Ok(groupDtos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetGroups)}");
                return StatusCode(500, Messages.Error500Message);
            }
          
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupReadOnlyDto>> GetGroup(int id)
        {
            if (_context.Groups == null)
            {
                return NotFound();
            }

            try
            {
                var group = await _context.Groups.FindAsync(id);

                if (group == null)
                {
                    logger.LogWarning($"No data found in {nameof(GetGroup)} - ID: {id}");
                    return NotFound();
                }

                var groupDto = mapper.Map<GroupReadOnlyDto>(group);
                return Ok(groupDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetGroup)}");
                return StatusCode(500, Messages.Error500Message);
            }          
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup(int id, GroupUpdateDto groupDto)
        {
            if (id != groupDto.GroupId)
            {
                logger.LogWarning($"Invalid ID in {nameof(PutGroup)} - ID: {id}");
                return BadRequest();
            }
            
            var group = await _context.Groups.FindAsync(id);

            if (group == null)
            {
                logger.LogWarning($"{nameof(Group)} not found in  {nameof(PutGroup)} - ID: {id}");
                return NotFound();
            }

            mapper.Map(groupDto, group);

            _context.Entry(group).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!GroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    logger.LogError(ex, $"Error: PUT in {nameof(PutGroup)}");
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();
        }

        // POST: api/Groups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GroupCreateDto>> PostGroup(GroupCreateDto groupDto)
        {
            try
            {
                var group = mapper.Map<Group>(groupDto);
                _context.Groups.Add(group);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetGroup", new { id = group.GroupId }, group);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: POST in {nameof(PostGroup)}");
                return StatusCode(500, Messages.Error500Message);
            }
            
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            try
            {
                var group = await _context.Groups.FindAsync(id);
                if (group == null)
                {
                    logger.LogWarning($"{nameof(Group)} not found in {nameof(DeleteGroup)} - ID: {id}");
                    return NotFound();
                }

                _context.Groups.Remove(group);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: DELETE in {nameof(DeleteGroup)}");
                return StatusCode(500, Messages.Error500Message);
            }

        }

        private bool GroupExists(int id)
        {
            return (_context.Groups?.Any(e => e.GroupId == id)).GetValueOrDefault();
        }
    }
}
