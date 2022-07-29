using CentroDeportivoElBicho.Models;
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
            return Redirect("https://www.google.com/maps/place/Inacap/@-18.4690706,-70.3050283,17z/data=!3m1!4b1!4m5!3m4!1s0x915aa9a52e70dccd:0x7d52fb99c8b65011!8m2!3d-18.4690706!4d-70.3028396");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListaCliente()
        {
            var db = new ClienteContext();
            List<Models.Cliente> clientes = db.Clientes.ToList();
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