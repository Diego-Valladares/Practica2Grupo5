using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Practica2Grupo5.Models
{
    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; } = false;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaLimite { get; set; }

        // Llave foranea
        [ForeignKey("Lista")]
        public int IdLista { get; set; }
        public virtual Lista Lista { get; set; }
    }
}