using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MvcNotas.Controllers
{
    public class EstudiantesController: Controller
    {
        private readonly IConfiguration _config;
        public EstudiantesController(IConfiguration config)
        {
            _config = config;
        }

        // Vista principal con el formulario y la tabla
        public IActionResult Index()
        {
            // Pasamos la URL base de la API a la vista
            ViewBag.ApiBase = _config["ApiSettings:BaseUrl"];
            return View();
        }
    }
}
