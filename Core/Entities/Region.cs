using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Region
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreRegion { get; set; }
        public int IdEstadoFk { get; set; }
        [ForeignKey("IdEstadoFk")]
        public virtual Region Regions { get; set; }
    }
}