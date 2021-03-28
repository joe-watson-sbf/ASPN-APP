using System;
using System.Collections.Generic;
using ASPNPlatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNPlatzi.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult index()
        {
            ViewBag.Information = "Klas sa enpòtan anpil pou devlòpman WEB";
            ViewBag.Fecha = DateTime.Now;
            return View(new Asignatura{Nombre = "Programacion Orientado a Objeto", UniqueId = Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAsignatura()
        {
            var asignatura = new Asignatura();
            asignatura.Nombre = "Programacion Orientado a Objeto";
            asignatura.UniqueId = Guid.NewGuid().ToString();

            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre = "Programacion Orientado a Objeto", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Matemáticas", UniqueId = Guid.NewGuid().ToString()} ,
                new Asignatura{Nombre="Educación Física", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias Naturales", UniqueId = Guid.NewGuid().ToString()}
            };

            ViewBag.Information = "Klas sa enpòtan anpil pou devlòpman WEB";
            ViewBag.Fecha = DateTime.Now;
            
            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}