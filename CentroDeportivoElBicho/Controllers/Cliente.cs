using CentroDeportivoElBicho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CentroDeportivoElBicho.Controllers
{
    public class Cliente : Controller
    {
        public IActionResult IndexCliente()
        {
            return View();
        }

        public IActionResult LoginCliente()
        {
            return View();
        }
        public IActionResult RegisterCliente()
        {
            return View();
        }



    }
}
