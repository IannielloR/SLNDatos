using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.Models
{
    public class LineaAerea
    {

        public int LineaAereaId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get;set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }

        public List<Avion> Aviones { get; set; }
    }
}
