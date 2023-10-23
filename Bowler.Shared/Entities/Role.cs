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
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del rol es obligatorio")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 cáracteres")]
        public string Nombre { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
