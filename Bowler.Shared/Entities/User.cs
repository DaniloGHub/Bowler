using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class User
    {
        [Required(ErrorMessage = "El ID del usuario es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del usuario es obligatorio")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El email del usuario es obligatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del usuario es obligatoria")]
        public string? Fecha_Nacimiento { get; set; }

        [Required(ErrorMessage = "El telefono del usuario es obligatorio")]
        public string? Telefono { get; set; }

        public string FullName => $"{Nombre} {Apellido}";

        public ICollection<UserRole>? UserRoles { get; set; }

        public ICollection<Reserva>? Reservas { get; set; }
    }
}
