using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas.Models
{
    public class Especialidad
    {
        public int Id { get; set; }
        
        [Display(Name = "Especialidad")]
        public string TituloEspecialidad { get; set; }
    }
}
