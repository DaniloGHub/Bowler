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
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        public string Precio { get; set; }

        [Required(ErrorMessage = "El stock del producto es obligatorio")]
        public string Stock { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Promocion> Promociones { get; set; }
    }
}
