using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandingPage.API.Data;
using AutoMapper;
using LandingPage.API.Models.Tenant;
using LandingPage.API.Static;
using Microsoft.AspNetCore.Authorization;

namespace LandingPage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class TenantsController : ControllerBase
    {
        private readonly AthenaPayLandingPageDbContext _context;
        private readonly IMapper mapper;
        private readonly ILogger<TenantsController> logger;

        public TenantsController(AthenaPayLandingPageDbContext context, IMapper mapper, ILogger<TenantsController> logger)
        {
            _context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        // GET: api/Tenants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TenantReadOnlyDto>>> GetTenants()
        {
              if (_context.Tenants == null)
              {
                logger.LogWarning($"Data not found in {nameof(GetTenants)}");
                return NotFound();
              }
             
            try
            {
                var tenants = await _context.Tenants
                    .Include(qt => qt.GroupTenants)
                    .ThenInclude(g => g.Group)
                    .ToListAsync();
                
                var tenantDtos = mapper.Map<IEnumerable<TenantReadOnlyDto>>(tenants);
                return Ok(tenantDtos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetTenants)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // GET: api/Tenants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TenantReadOnlyDto>> GetTenant(int id)
        {
            if (_context.Tenants == null)
            {
                logger.LogWarning($"Data not found in {nameof(GetTenant)}");
                return NotFound();
            }
            
            try
            {
                var tenant = await _context.Tenants
                .Include(qt => qt.GroupTenants)
                .ThenInclude(g => g.Group)
                .Where(x => x.TenantId == id)
                .FirstOrDefaultAsync();

                if (tenant == null)
                {
                    return NotFound();
                }

                var tenantDto = mapper.Map<TenantReadOnlyDto>(tenant);

                return Ok(tenantDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: GET in {nameof(GetTenant)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT: api/Tenants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutTenant(int id, TenantUpdateDto tenantDto)
        {
            if (id != tenantDto.TenantId)
            {
                logger.LogWarning($"Invalid ID in {nameof(PutTenant)} - ID: {id}");
                return BadRequest();
            }

            var tenant = await _context.Tenants.FindAsync(id);

            if (tenant == null)
            {
                logger.LogWarning($"{nameof(Tenant)} not found in  {nameof(PutTenant)} - ID: {id}");
                return NotFound();
            }

            mapper.Map(tenantDto, tenant);
            _context.Entry(tenant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!TenantExists(id))
                {
                    logger.LogWarning($"Data not found in {nameof(PutTenant)}");
                    return NotFound();
                }
                else
                {
                    logger.LogError(ex, $"Error: PUT in {nameof(PutTenant)}");
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();
        }

        // POST: api/Tenants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tenant>> PostTenant(TenantCreateDto tenantDto)
        {
          
            try
            {
                var tenant = mapper.Map<Tenant>(tenantDto);
                _context.Tenants.Add(tenant);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTenant", new { id = tenant.TenantId }, tenant);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: POST in {nameof(PostTenant)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // DELETE: api/Tenants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTenant(int id)
        {
            try
            {
                var tenant = await _context.Tenants.FindAsync(id);
                if (tenant == null)
                {
                    logger.LogWarning($"{nameof(Tenant)} not found in {nameof(DeleteTenant)} - ID: {id}");
                    return NotFound();
                }

                _context.Tenants.Remove(tenant);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error: DELETE in {nameof(DeleteTenant)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        private bool TenantExists(int id)
        {
            return (_context.Tenants?.Any(e => e.TenantId == id)).GetValueOrDefault();
        }
    }
}
