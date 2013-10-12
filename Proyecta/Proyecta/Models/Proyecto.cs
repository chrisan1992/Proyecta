﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecta.Models
{

    public class IProyecto
    {

        [Display(Name = "Descripción del proyecto")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(512, ErrorMessage = "La propuesta no puede ser mayor a 256 caracteres")]
        public string Propuesta { get; set; }

        [Display(Name = "¿Qué ocupo?")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(512, ErrorMessage = "Los recursos no pueden ser mayor a 256 caracteres")]
        public string Recursos { get; set; }

        [Display(Name = "Provincia")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(20, ErrorMessage = "La provincia no puede ser mayor a 20 caracteres")]
        public string Provincia { get; set; }

        [Display(Name = "Cantón")]
        [Required(ErrorMessage = "obligatorio")]
        [StringLength(20, ErrorMessage = "El cantón no puede ser mayor a 20 caracteres")]
        public string Canton { get; set; }

    }

    [MetadataType(typeof(IUsuario))]
    public partial class Proyecto
    {
        public List<Proyecto> Get3FeaturedProyectos()
        {
            // Christopher
            return new List<Proyecto>();
        }
    }
}