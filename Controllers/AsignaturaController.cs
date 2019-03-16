using System;
using System.Linq;
using escuela_asp_net_core.Models;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;


namespace Facturacion.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index() {
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método
            
            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",_context.Asignaturas);
            //return View(listaAsignaturas);
        }

        public EscuelaContext _context;
        public AsignaturaController (EscuelaContext context){
            _context = context;
        }
    }
}