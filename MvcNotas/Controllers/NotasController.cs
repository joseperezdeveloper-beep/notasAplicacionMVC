using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MvcNotas.Controllers
{
    public class NotasController:Controller
    {
        private readonly IConfiguration _config;
        public NotasController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            ViewBag.ApiBase = _config["ApiSettings:BaseUrl"];
            return View();
        }
    }
}
