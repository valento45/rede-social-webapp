using Microsoft.AspNetCore.Mvc;
using Rede.Social.Domain.Authorization;
using Rede.Social.Service.Interfaces;

namespace Rede.Social.WebApp.Controllers
{
    public class FeedController : Controller
    {
        public async Task<IActionResult> Index()
        {
            if (!User.IsAuthenticated())
                return View("Unauthorized");

            return View("Feed");
        }


        [HttpGet]
        public async Task<IActionResult> Feed()
        {
            if (!User.IsAuthenticated())
                return View("Unauthorized");

            return View("Feed");
        }

    }
}
