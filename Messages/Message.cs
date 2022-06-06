using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHistoriasClinicas.Messages
{
    public class Message
    {
        public const string NombreCompleto = "Nombre Completo";
        public const string Email = "Correo Electrónico";
        public const string Contrasena = "Contraseña";
        public const string FechaHora = "Fecha y hora";
        public const string FechaDe= "Fecha de ";
        public const string FechaAlta = FechaDe + "Alta";
        public const string FechaCierre = FechaDe + "Cierre";
        public const string FechaInicio = FechaDe + "Inicio";
        public const string Descripcion = "Descripción";
        public const string CodPostal = "Código Postal";
        public const string Estado = "Estado";
        public const string ObraSocial = "Obra Social";

        public const string Requerido = "El campo {0} es requerido";
        public const string RangoMinMax = "El campo {0} debe estar comprendido entre {1} y {2}";
        public const string StrMinMax = "El campo {0}, debe tener un mínimo de {2} y un máximo de {1}";
        public const string StrMax = "El campo {0}, debe tener un máximo de {1}";
        public const string Generico = "Verifique el ingreso del campo {0}";
        public const string NoValido = "El campo {0} no es válido";
        public const string FixedSize = "El campo {0} debe tener {1} caracteres";
    }
}
