using CentroDeportivoElBicho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CentroDeportivoElBicho.Controllers
{
    public class Dueño : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginDueño()
        {
            var db = new ClienteContext();
            var personas = db.Clientes.ToList();
            ViewBag.Personas = personas;


            return View();
        }
    }
}
