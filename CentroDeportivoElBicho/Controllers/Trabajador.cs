using CentroDeportivoElBicho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CentroDeportivoElBicho.Controllers
{
    public class Trabajador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginTrabajador()
        {
            return View();
        }
    }
}
