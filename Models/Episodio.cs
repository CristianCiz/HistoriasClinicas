using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Episodio
    {
        [Key]
        public int Id { get; set; }
        public string Motivo { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaInicio))]
        public DateTime FechaYHoraInicio { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaAlta))]
        public DateTime? FechaYHoraAlta { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(Message.FechaCierre))]
        public DateTime? FechaYHoraCierre { get; set; }

        [Display(Name = Message.Estado)]
        public bool EstadoAbierto { get; set; }

        [ForeignKey(nameof(HistoriaClinica))]
        public int HistoriaClinicaId { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }

        public ICollection<Evolucion> Evoluciones { get; set; }
        public ICollection<Epicrisis> ListaEpicrisis { get; set; }
        public Empleado EmpleadoRegistra { get; set; }
    }
}
