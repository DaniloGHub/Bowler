using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class Producto
    {
        [Required(ErrorMessage = "El ID del producto es obligatorio")]
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 cáracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [MaxLength(6, ErrorMessage = "La {0} debe tener máximo 6 caractéres.")]
        public string Precio { get; set; }

        [Required(ErrorMessage = "El stock del producto es obligatorio")]
        [MaxLength(6, ErrorMessage = "La {0} debe tener máximo 6 caractéres.")]
        public string Stock { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La {0} debe tener máximo 200 caractéres.")]
        public string Descripcion { get; set; }

        public ICollection<Promocion> Promociones { get; set; }
    }
}
