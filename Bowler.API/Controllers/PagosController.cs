using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/pagos")]
    public class PagosController : ControllerBase
    {
        private readonly DataContext _context;

        public PagosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Pagos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var pago = await _context.Pagos.FirstOrDefaultAsync(x => x.Id == id);
            if (pago == null)
            {
                return NotFound();
            }
            return Ok(pago);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Pago pago)
        {
            _context.Add(pago);
            await _context.SaveChangesAsync();
            return Ok(pago);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Pago pago)
        {
            _context.Update(pago);
            await _context.SaveChangesAsync();
            return Ok(pago);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Pagos
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