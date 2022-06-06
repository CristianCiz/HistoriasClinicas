using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestHistoriasClinicas.Messages;

namespace TestHistoriasClinicas.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = Message.Email)]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = Message.FechaAlta)]
        public DateTime FechaAlta { get; set; }

        [Display(Name = Message.Contrasena)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
