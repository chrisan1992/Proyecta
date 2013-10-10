using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecta.Models
{
    public class IUsuario
    {
        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "required")]
        [StringLength(20, ErrorMessage = "Contraseña de no más de 20 caracteres")]
        public string Cedula { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "required")]
        [StringLength(15, ErrorMessage = "La cédula tiene que ser menor que 15 caracteres")]
        public string Password { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "required")]
        [StringLength(40, ErrorMessage = "Correo demasiado largo")]
        public string Correo { get; set; }
    }

    [MetadataType(typeof(IUsuario))]
    public partial class Usuario
    {

    }
}