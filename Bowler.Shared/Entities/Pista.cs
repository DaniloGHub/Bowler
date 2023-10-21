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
        public int Id { get; set; }

        [Required(ErrorMessage = "El estado de la pista es obligatorio")]
        public string Estado { get; set; } = null;

        public string Descripcion { get; set; } = null;
    }
}
