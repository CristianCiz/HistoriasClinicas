using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Evolucion))]
        public int EvolucionId { get; set; }
        public Evolucion Evolucion { get; set; }
       
        public string Mensaje { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaHora))]
        public DateTime FechaYHora { get; set; }
        
        [ForeignKey(nameof(Persona))]
        public int PersonaId { get; set; } // Se hara referencia al empleado o medico que carga la nota
        public Persona Persona { get; set; }
    }
}
