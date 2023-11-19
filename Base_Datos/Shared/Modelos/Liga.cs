using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Datos.Shared.Modelos
{
    public class Liga
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre de la liga")]
        [StringLength(100)]
        public string? Nombre_liga { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre de la confederacion")]
        [StringLength(50)]
        public string? Confederacion { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre del pais")]
        [StringLength(50)]
        public string? Pais { get; set; }
        [Required(ErrorMessage = "Debe escribir el URL de la imagen")]
        [StringLength(250)]
        public string? Logo { get; set; }
    }
}
