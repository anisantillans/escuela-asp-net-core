using System;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;


namespace Facturacion.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método
            var escuela = new Escuela();
            escuela.AnioFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Narvaez School";

            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            return View(escuela);
        }
    }
}