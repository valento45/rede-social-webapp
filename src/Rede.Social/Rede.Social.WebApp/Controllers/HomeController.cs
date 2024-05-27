using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rede.Social.Domain.Authorization;
using Rede.Social.Domain.Models;
using Rede.Social.Repository.Interfaces;
using Rede.Social.Service.Interfaces;
using Rede.Social.Service.Responses;
using Rede.Social.WebApp.Models;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace Rede.Social.WebApp.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public HomeController(UserManager<Usuario> userManager, IUsuarioService usuarioService) : base(userManager)
        {
            _usuarioService = usuarioService;
        }


        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(LoginViewModel loginViewModel)
        {
            if (!await _usuarioService.ExisteUsuario(loginViewModel.Email))
            {

                loginViewModel.Message = "Email não cadastrado";
                return View("Login", loginViewModel);
            }


            var result = await base.Autenticar(loginViewModel);

            if (result != null)
                return RedirectToAction("Feed", "Feed", result);
            else
            {
                loginViewModel.Message = "Usuário ou senha inválidos";
                return View("Login", loginViewModel);
            }
        }

        [HttpGet]
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