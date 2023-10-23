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
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        [Required(ErrorMessage = "El ID del evento es obligatorio")]
        public int Id { get; set; }

        public Pista Pista { get; set; }

        public int PistaId { get; set; }

        [Required(ErrorMessage = "El nobre del evento es obligatorio")]
        [StringLength(50, ErrorMessage ="No puede tener más de 50 cáracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha del evento es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "La capacidad máxima del evento es obligatoria")]
        [MaxLength(3, ErrorMessage = "La {0} debe tener máximo 3 caractéres.")]
        public int Capacidad { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripcion { get; set; }
    }
}
