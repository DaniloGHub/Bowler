using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/pistas")]
    public class PistasController : ControllerBase
    {
        private readonly DataContext _context;

        public PistasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Pistas.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var pista = await _context.Pistas.FirstOrDefaultAsync(x => x.Id == id);
            if (pista == null)
            {
                return NotFound();
            }
            return Ok(pista);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Pista pista)
        {
            _context.Add(pista);
            await _context.SaveChangesAsync();
            return Ok(pista);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Pista pista)
        {
            _context.Update(pista);
            await _context.SaveChangesAsync();
            return Ok(pista);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Pistas
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