using Bowler.API.Data;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bowler.API.Controllers
{
    [ApiController]
    [Route("api/reservas")]
    public class ReservasController:ControllerBase
    {
        private readonly DataContext _context;

        public ReservasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Reservas.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var reserva= await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if (reserva == null) 
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Reserva reserva)
        {
            _context.Add(reserva);
            await _context.SaveChangesAsync();
            return Ok(reserva);
        }
    }
}