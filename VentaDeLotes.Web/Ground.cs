using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentaDeLotes.Web
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ground
    {
        [Key]
        public in GroundId { get; set }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracter")]
    [Index("GroundNameIndez", IsUnique = true)]
    }
}
