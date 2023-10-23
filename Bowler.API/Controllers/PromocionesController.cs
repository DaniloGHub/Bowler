using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/promociones")]
    public class PromocionesController : ControllerBase
    {
        private readonly DataContext _context;

        public PromocionesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Promociones.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var promocion = await _context.Promociones.FirstOrDefaultAsync(x => x.Id == id);
            if (promocion == null)
            {
                return NotFound();
            }
            return Ok(promocion);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Promocion promocion)
        {
            _context.Add(promocion);
            await _context.SaveChangesAsync();
            return Ok(promocion);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Promocion promocion)
        {
            _context.Update(promocion);
            await _context.SaveChangesAsync();
            return Ok(promocion);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Promociones
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