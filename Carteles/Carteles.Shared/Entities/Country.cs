using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteles.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [DisplayName("Pais")]
        [Required(ErrorMessage ="El campo {0} es requerido.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres.")]
        public string Name { get; set; }

    }
}
