using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Empleado : Persona
    {
        
        [Required(ErrorMessage = Message.Requerido)]
        public string Legajo { get; set; }

        //public int EpisodioId { get; set; } // Esta Ok ? Revisar
        //public Episodio Episodio { get; set; } // Esta Ok ? Revisar
    }
}
