using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Reserva
    {
        [Required(ErrorMessage ="El ID de la reserva es obligatorio")]
        public int Id { get; set; }

        public User? User { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "El valor de la reserva es obligatorio")]
        public string? Valor { get; set; }

        [Required(ErrorMessage = "La fecha de la reserva es obligatoria")]
        public string? Fecha { get; set; }

        [Required(ErrorMessage = "La duración de la reserva es obligatoria")]
        public string? Duracion { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Pago>? Pagos { get; set; }
    }
}
