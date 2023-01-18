using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.Models
{
    [Table("Avion")]
    public class Avion
    {
        public int AvionId { get; set; }

        [Column(TypeName = "int")]
        public int Capacidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set;}

        public int LAereaId { get; set; }

        [ForeignKey("LAereaId")]
        
        public LineaAerea LineaAerea { get; set; }
        
        
    }
}
