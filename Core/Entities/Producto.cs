using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Producto
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string CodInterno { get; set;}
        public string Nombre { get; set;}
        public int StockMin  { get; set;}
        public int StockMax { get; set;}
        public int Stock { get; set;}
        public double ValorVta { get; set;}
        
    }
}