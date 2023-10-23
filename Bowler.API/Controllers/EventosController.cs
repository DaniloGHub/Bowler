using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/eventos")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Eventos.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var evento = await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if (evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Evento evento)
        {
            _context.Add(evento);
            await _context.SaveChangesAsync();
            return Ok(evento);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Evento evento)
        {
            _context.Update(evento);
            await _context.SaveChangesAsync();
            return Ok(evento);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Eventos
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
