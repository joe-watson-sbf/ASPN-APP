using System;
using System.Collections.Generic;
using System.Linq;
using ASPNPlatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNPlatzi.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult index()
        {
            ViewBag.Information = "Se yon boon elèv";
            ViewBag.Fecha = DateTime.Now;
            return View(new Alumno{Nombre = "Joe Watson SBF", UniqueId = Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno()
        {
            var asignatura = new Asignatura();
            asignatura.Nombre = "Programacion Orientado a Objeto";
            asignatura.UniqueId = Guid.NewGuid().ToString();

            var listaAlumnos = GenerarAlumnosAlAzar();

            ViewBag.Information = "Se yon boon elèv";
            ViewBag.Fecha = DateTime.Now;
            
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
                               select new Alumno { Nombre = $"{n1} {n2} {a1}", UniqueId = Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}