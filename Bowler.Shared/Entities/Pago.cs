using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Pago
    {
        [Required(ErrorMessage = "El ID del pago es obligatorio")]
        public int Id { get; set; }

        public Reserva? Reserva { get; set; }

        public int ReservaId { get; set; }

        [Required(ErrorMessage = "El precio del pago es obligatorio")]
        public string? Precio { get; set; }

        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        public string? Fecha { get; set; }

        [Required(ErrorMessage = "El metodo de pago es obligatorio")]
        public string? Metodo_Pago { get; set; }

        [Required(ErrorMessage = "El estgado del pago es obligatorio")]
        public string? Estado { get; set; }

        public string? Descripcion { get; set; }
    }
}
