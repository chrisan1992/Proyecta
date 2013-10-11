﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
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
        [Email(ErrorMessage="Correo inválido")]
        [StringLength(40, ErrorMessage = "Correo demasiado largo")]
        public string Correo { get; set; }
    }

    [MetadataType(typeof(IUsuario))]
    public partial class Usuario
    {
        public List<Usuario> GetAllUsuarios()
        {
            try
            {
                ModeloDataContext ct = new ModeloDataContext();
                List<Usuario> lista = (from a in ct.Usuarios select a).ToList();
                ct.Dispose();

                return lista;
            }
            catch (Exception e)
            {
                return new List<Usuario>();
            }
        }

        public bool CreateUsario(Usuario us)
        {
            try
            {
                ModeloDataContext ct = new ModeloDataContext();
                us.id = new Guid();
                ct.Usuarios.InsertOnSubmit(us);
                ct.SubmitChanges();
                ct.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}