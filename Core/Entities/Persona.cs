using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Persona
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdPersona { get; set;}
        public string NombrePersona { get; set; }
        public DateTime FechaNac { get; set;}
        public int IdTipoPersoa { get; set;}
        
    }
}