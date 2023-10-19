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
        public string Id { get; set; } = null;
        [Required(ErrorMessage = "El precio del pago es obligatorio")]
        public string Precio { get; set; } = null;
        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        public string fecha { get; set; } = null;
        [Required(ErrorMessage = "El metodo de pago es obligatorio")]
        public string metodo_pago { get; set; } = null;
        [Required(ErrorMessage = "El estgado del pago es obligatorio")]
        public string estado { get; set; } = null;
        public string Descripcion { get; set; } = null;
    }
}
