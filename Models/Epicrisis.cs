using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Epicrisis
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Episodio))]
        public int EpisodioId { get; set; }
        public Episodio Episodio { get; set; }


        [ForeignKey(nameof(Medico))] // ??
        public int MedicoId { get; set; }
        public Medico Medico { get; set; } // ?

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaHora))]
        public DateTime FechaYHora { get; set; }

        [ForeignKey(nameof(Diagnostico))]
        public int DiagnosticoId { get; set; }
        public Diagnostico Diagnostico { get; set; }
    }
}
