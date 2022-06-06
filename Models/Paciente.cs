using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        [Range(11111111, 99999999, ErrorMessage = Message.RangoMinMax)]
        public int Dni { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        public int Telefono { get; set; }


        [Required(ErrorMessage = Message.Requerido)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        [DataType(DataType.DateTime)]
        [Display(Name = Message.FechaAlta)]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = Message.Requerido)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [NotMapped]
        [Display(Name = Message.NombreCompleto)]
        public string NombreCompleto
        {
            get
            {
                return $"{Apellido.ToUpper()}, {Nombre}";
            }
        }
        [Display(Name = Message.ObraSocial)]
        public string ObraSocial { get; set; }


        [ForeignKey(nameof(HistoriaClinica))]
        public int HistoriaClinicaId { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
    }
}
