using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas.Models
{
    public class Medico : Persona
    {
       
        public string Matricula { get; set; }


        [ForeignKey(nameof(Especialidad))]
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
