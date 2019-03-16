using System;
using System.Linq;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using escuela_asp_net_core.Models;

namespace Facturacion.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index() {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método       
            
            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
            //return View("MultiAsignatura",listaAsignaturas);
            return View("MultiAlumno", _context.Alumnos);
        }

        public EscuelaContext _context;
        public AlumnoController (EscuelaContext context){
            _context = context;
        }
    }
}