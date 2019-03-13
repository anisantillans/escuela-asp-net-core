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
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Narvaez School";
            escuela.Dirección = "America Oeste 456";
            escuela.Ciudad = "Lima";
            escuela.Pais = "Perú";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            return View(escuela);
        }
    }
}