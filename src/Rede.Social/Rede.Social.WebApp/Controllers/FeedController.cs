using Microsoft.AspNetCore.Mvc;
using Rede.Social.Service.Interfaces;

namespace Rede.Social.WebApp.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View("Feed");
        }


        [HttpGet]
        public async Task<IActionResult> Feed()
        {
            return View();
        }

    }
}
