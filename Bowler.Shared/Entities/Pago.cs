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
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        public Reserva Reserva { get; set; }

        public int ReservaId { get; set; }

        [Required(ErrorMessage = "El precio del pago es obligatorio")]
        [MaxLength(6, ErrorMessage = "La {0} debe tener máximo 6 caractéres.")]
        public string Precio { get; set; }

        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "El metodo de pago es obligatorio")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 cáracteres")]
        public string Metodo_Pago { get; set; }

        [Required(ErrorMessage = "El estgado del pago es obligatorio")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 cáracteres")]
        public string Estado { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripcion { get; set; }
    }
}
