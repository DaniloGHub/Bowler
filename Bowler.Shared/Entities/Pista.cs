using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Pista
    {
        [Required(ErrorMessage = "El Id de la pista es obligatorio")]
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El estado de la pista es obligatorio")]
        [MaxLength(20, ErrorMessage = "La {0} debe tener máximo 20 caractéres.")]
        public string Estado { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripcion { get; set; }

        public ICollection<Evento> Eventos { get; set; }
    }
}
