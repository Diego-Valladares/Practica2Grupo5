using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practica2Grupo5.Models
{
    public class Practica2Grupo5Context : DbContext
    {
        public Practica2Grupo5Context() : base("Practica2Grupo5DB")
        {
        }   

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Lista> Listas { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }

}