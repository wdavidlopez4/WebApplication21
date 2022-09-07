using Microsoft.AspNetCore.Mvc;
using WebApplication21.Models;
using WebApplication21.Services;

namespace WebApplication21.Controllers
{
    public class EscuelaController : Controller
    {
        private readonly EscuelaServices escuelaServices;

        public EscuelaController(EscuelaServices escuelaServices)
        {
            this.escuelaServices = escuelaServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var escuelas = await escuelaServices.GetAllEscuelas();
            return View(escuelas);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(string name, string direccion, string tipo)
        {
            var escuela = Escuela.Build(Guid.NewGuid(), name, direccion, tipo);
            await this.escuelaServices.Crear(escuela);

            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
    }
}
