﻿using CentroDeportivoElBicho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CentroDeportivoElBicho.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReservaAqui()
        {
            return View();
        }
        public IActionResult QuienesSomos()
        {
            return View();
        }
        public IActionResult Ubicacion()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListaCliente()
        {
            var db = new ClienteContext();
            var clientes = db.Clientes.ToList();
            ViewBag.Clientes = clientes;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}