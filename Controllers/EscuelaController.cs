using System;
using ASPNPlatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNPlatzi.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela() ;
            escuela.AnoDeCreacion=2019;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Program et Action";
            ViewBag.Information = "Tout kou nou yo fèt an KREYÒL AYISYEN!";
            
            return View(escuela);
        }
    }
}