using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            ViewBag.NumVeces = numVeces;

            int cont = 1;
            ViewBag.cont = cont;

            ViewBag.Mensaje= "Hola "+nombre + " " + apellido + "," + " veces mostrado = ";
                       
            return View();
        }
    }
}