using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas.Models
{
    public class HistoriaClinica
    {
        [Key]
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public ICollection<Episodio> Episodios { get; set; }
    }
}
