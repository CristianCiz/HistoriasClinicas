using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TestHistoriasClinicas.Messages;


namespace TestHistoriasClinicas.Models
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Altura { get; set; }
        
        [Display(Name=Message.CodPostal)]
        public int CodigoPostal { get; set; }
        public int Piso { get; set; }
        public string Dpto { get; set; }
    }
}