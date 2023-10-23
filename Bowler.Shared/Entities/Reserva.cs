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
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "El valor de la reserva es obligatorio")]
        [MaxLength(6, ErrorMessage = "La {0} debe tener máximo 6 caractéres.")]
        public string Valor { get; set; }

        [Required(ErrorMessage = "La fecha de la reserva es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "La duración de la reserva es obligatoria")]
        [MaxLength(20, ErrorMessage = "La {0} debe tener máximo 20 caractéres.")]
        public string Duracion { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripcion { get; set; }

        //public ICollection<Pago> Pagos { get; set; }
    }
}
