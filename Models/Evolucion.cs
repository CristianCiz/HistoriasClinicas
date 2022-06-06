using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Evolucion
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaInicio))]
        public DateTime FechaYHoraInicio { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaAlta))]
        public DateTime FechaYHoraAlta { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaCierre))]
        public DateTime FechaYHoraCierre { get; set; }

        [Display(Name = Message.Descripcion)]
        public string Descripcion { get; set; }

        [Display(Name = Message.Estado)]
        public bool EstadoAbierto { get; set; }

        public Medico Medico { get; set; } // Medico Id ?
        public ICollection<Nota> Notas { get; set; }

        [ForeignKey(nameof(Episodio))]
        public int EpisodioId { get; set; }
        public Episodio Episodio { get; set; }

    }
}
