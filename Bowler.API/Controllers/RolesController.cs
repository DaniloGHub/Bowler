using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RolesController : ControllerBase
    {
        private readonly DataContext _context;

        public RolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Roles.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Role role)
        {
            _context.Add(role);
            await _context.SaveChangesAsync();
            return Ok(role);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Role role)
        {
            _context.Update(role);
            await _context.SaveChangesAsync();
            return Ok(role);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Roles
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}