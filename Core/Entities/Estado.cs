using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Estado
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string NombreEstado { get; set; }
        public int idPaisFk { get; set; }

        [ForeignKey("idPaisFk")]
        public virtual Pais Pais { get; set; }
    }
}