
using AppWebProductosCF.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BancoGL.Models
{

    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El nombtre no debe tener mas de 50 caracteres, ni menos de 3 caracteres")]

        public string Nombre { get; set; }
        [StringLength(255,
            ErrorMessage = "La descrpcion no debe tener mas 26556 caracteres")]
        [Display(Name = "Descripcion")]

        public string Descripcion { get; set; }
        [Required  (ErrorMessage = "El estado es obligatorio")]


        
        public bool Estado { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
