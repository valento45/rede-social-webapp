using Microsoft.AspNetCore.Mvc;
using Rede.Social.Domain.Models;
using Rede.Social.Repository.Interfaces;
using Rede.Social.Service.Interfaces;
using Rede.Social.WebApp.Models;
using System.Diagnostics;

namespace Rede.Social.WebApp.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioService _usuarioService;

        public HomeController(ILogger<HomeController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Logar")]
        public async Task<IActionResult> Logar(LoginViewModel loginViewModel)
        {

            
            throw new Exception();
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