using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/userroles")]
    public class UserRolesController : ControllerBase
    {
        private readonly DataContext _context;

        public UserRolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.UserRoles.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var userrole = await _context.UserRoles.FirstOrDefaultAsync(x => x.Id == id);
            if (userrole == null)
            {
                return NotFound();
            }
            return Ok(userrole);
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserRole userrole)
        {
            _context.Add(userrole);
            await _context.SaveChangesAsync();
            return Ok(userrole);
        }
    }
}