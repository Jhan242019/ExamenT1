using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Models
{
    public class Personas
    {
        [Required(ErrorMessage = "El campo id es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo fecNac es obligatorio")]
        public DateTime FechaNac { get; set; }

        [Required(ErrorMessage = "El campo dni es obligatorio")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "El campo Genero es obligatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "El campo ciudad es obligatorio")]
        public int Ciudad { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El campo UserName es obligatorio")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo UserName es obligatorio")]
        public string Contrasena { get; set; }

        public Ciudad NomCiudad { get; set; }
    }
}
