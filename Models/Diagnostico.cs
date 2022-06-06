using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas.Models
{
    public class Diagnostico
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Recomendacion { get; set; }
        public Epicrisis Epicrisis { get; set; }
    }
}
