using System;
using ASPNPlatzi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNPlatzi.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AnoFundacion=2019;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Program et Action";
            ViewBag.Information = "Tout kou nou yo fèt an KREYÒL ayisyen!";
            
            return View(escuela);
        }
    }
}