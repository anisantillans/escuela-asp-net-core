using System;
using System.Linq;
using Facturacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Facturacion.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index() {
            var asignatura = new Asignatura{
                Nombre="Pepe Perez",
                UniqueId = Guid.NewGuid().ToString()
            };
            return View(asignatura);
        }
        public IActionResult MultiAlumno() {
            //si no especificamos el nombre de la vista, entiende que es en nombre del método
           var listaAlumnos = GenerarAlumnosAlAzar();
                        
            
            //Bolsa de cosas dinámica
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;
            //return View("MultiAsignatura",listaAsignaturas);
            return View("MultiAlumno",listaAlumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}