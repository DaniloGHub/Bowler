using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Promocion
    {
        [Required(ErrorMessage = "El ID de la promoción es obligatorio")]
        public int Id { get; set; }

        public Producto Producto { get; set; }

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El nombre de la promoción es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio de la promoción es obligatoria")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "La fecha de finalización de la promoción es obligatoria")]
        public string EndDate { get; set; }

        public string Descripción { get; set; }
    }
}
