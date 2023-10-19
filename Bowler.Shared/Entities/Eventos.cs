using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Eventos
    {
        [Required(ErrorMessage = "El ID del evento es obligatorio")]
        public string Id { get; set; } = null;
        [Required(ErrorMessage = "El nobre del evento es obligatorio")]
        public string Nombre { get; set; } = null;
        [Required(ErrorMessage = "La fecha del evento es obligatoria")]
        public string Fecha { get; set; } = null;
        [Required(ErrorMessage = "La capacidad máxima del evento es obligatoria")]
        public string Capacidad { get; set; } = null;
        public string Descripcion { get; set; } = null;
    }
}
