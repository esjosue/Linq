using Ejemplo_LinQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_LinQ.Controllers
{
    public class studentController : Controller
    {
        alumnos db = new alumnos();
        // GET: student
        public ActionResult Index()
        {
            var Listado = db.Lista();


            return View(Listado.ToList());
        }
    }
}