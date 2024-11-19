using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Practica2Grupo5.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        // Relacion con Listas
        public virtual ICollection<Lista> Listas { get; set; }
    }
}