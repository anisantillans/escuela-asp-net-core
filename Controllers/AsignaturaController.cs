using System;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;


namespace Facturacion.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index() {
            var asignatura = new Asignatura{
                Nombre="Programación",
                UniqueId = Guid.NewGuid().ToString()
            };
            return View(asignatura);
        }
        public IActionResult MultiAsignatura() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método
           var listaAsignaturas = new System.Collections.Generic.List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",
                                UniqueId = Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                UniqueId = Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                UniqueId = Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId = Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Programación",
                                UniqueId = Guid.NewGuid().ToString()
                            }
            };
            
            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",listaAsignaturas);
            //return View(listaAsignaturas);
        }
    }
}