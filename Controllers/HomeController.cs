using Contacto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Contacto.Controllers
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
            return View(new MensajeUsuario());
        }

        [HttpPost]
        public IActionResult CapturarDatos(MensajeUsuario unMensaje)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", unMensaje);
            }
            else
            {
                return View("Index", unMensaje);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
