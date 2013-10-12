using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecta.Models
{
    public class IPersona
    {
        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(20, ErrorMessage = "Cédula de no más de 20 caracteres")]
        public string Cedula { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(20, ErrorMessage = "El nombre de no más de 20 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(20, ErrorMessage = "El primer apellido de no más de 20 caracteres")]
        public string Apellido1 { get; set; }

        [Display(Name = "Segundo Apellido")]
        [StringLength(20, ErrorMessage = "El segundo apellido de no más de 20 caracteres")]
        public string Apellido2 { get; set; }

        [Display(Name = "Género")]
        public char Genero { get; set; }

        [Display(Name = "Foto de usuario")]
        public string urlFoto { get; set; }
    }

    [MetadataType(typeof(IPersona))]
    public partial class Persona
    {
    }
}