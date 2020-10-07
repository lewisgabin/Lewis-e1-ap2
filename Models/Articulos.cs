using System.ComponentModel.DataAnnotations;

namespace Lewis_e1_ap2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "Debe ingresar la descripcion del producto")]
        [MinLength(3, ErrorMessage = "La descripcion debe ser mas larga")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debe ingresar la cantidad del productopara el inventario")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Debe ingresar el costo del articulo")]
        public decimal Costo { get; set; }
        [Required]
        public decimal ValorInventario { get; set; }

    }
}