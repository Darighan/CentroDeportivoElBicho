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
            return View();
        }
    }
}
