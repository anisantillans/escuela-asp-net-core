using System;
using System.Linq;
using escuela_asp_net_core.Models;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion.Controllers
{
    public class EscuelaController : Controller
    {
        public EscuelaContext _context;
        public IActionResult Index() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método

            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController (EscuelaContext context){
            _context = context;
        }
    }
}