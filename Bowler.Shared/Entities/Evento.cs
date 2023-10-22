using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Evento
    {
        [Required(ErrorMessage = "El ID del evento es obligatorio")]
        public int Id { get; set; }

        public Pista? Pista { get; set; }

        public int PistaId { get; set; }

        [Required(ErrorMessage = "El nobre del evento es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La fecha del evento es obligatoria")]
        public string? Fecha { get; set; }

        [Required(ErrorMessage = "La capacidad máxima del evento es obligatoria")]
        public string? Capacidad { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Descripcion { get; set; }
    }
}
