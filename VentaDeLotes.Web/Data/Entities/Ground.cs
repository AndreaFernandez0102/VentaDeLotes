using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentaDeLotes.Web.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ground
    {
        [Key]
        public int GroundId { get; set; }



        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Terreno")]
        public string Grounds { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Cantidad")]
        public int Quatity { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }


    }
}
