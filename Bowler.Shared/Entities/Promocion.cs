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
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        public Producto Producto { get; set; }

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El nombre de la promoción es obligatorio")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 cáracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio de la promoción es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "La fecha de finalización de la promoción es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string EndDate { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripción { get; set; }
    }
}
