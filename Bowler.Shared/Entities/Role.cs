using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Role
    {
        [Required(ErrorMessage = "El ID es obligatorio")]
        public string ID { get; set; } = null;

        [Required(ErrorMessage = "El nombre del rol es obligatorio")]
        public string Nombre { get; set; } = null;
    }
}
