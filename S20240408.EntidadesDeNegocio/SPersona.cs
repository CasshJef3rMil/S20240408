using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S20240408.EntidadesDeNegocio
{
    public class SPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(60)]
        public string Apellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(60)]
        public decimal Sueldo { get; set; }

        public byte Estatus { get; set; }

    }
}
