using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica2Grupo5.Models
{
    public class Lista
    {
        [Key]
        public int IdLista { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Llave foranea
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        // Relacion con Tareas
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}