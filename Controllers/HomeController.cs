using Practica2Grupo5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2Grupo5.Controllers
{
    public class HomeController : Controller
    {

        private Practica2Grupo5Context db = new Practica2Grupo5Context();

        public ActionResult Test()
        {
            // Para probar si se ven las listas
            var listas = db.Listas.ToList();
            return View(listas);
        }

        public ActionResult DetailsLista() 
        {
            // Para probar la si se puedne ver las tareas dentro de cada lista
            var tareas = db.Tareas.ToList();
            return View(tareas);

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}