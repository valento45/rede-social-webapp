using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rede.Social.Domain.Authorization;
using Rede.Social.Domain.Models;
using System.Security.Claims;
using Rede.Social.Security;
using Microsoft.AspNetCore.Authentication;

namespace Rede.Social.WebApp.Controllers
{
    public class ControllerBase : Controller
    {
        protected readonly UserManager<Usuario> _userManager;

        public ControllerBase(UserManager<Usuario> userManager)
        {
            _userManager = userManager;
        }

        protected async Task<Usuario?> Autenticar(LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);


            if (user != null)
            {
                if (user.CheckPassword(model.PasswordHash))
                {
                    var identity = new ClaimsIdentity("cookies");

                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.IdUsuario.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Name, model.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Hash, model.PasswordHash));                    

                    var userClaim = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("cookies", userClaim);

                    return user;
                }
            }

            return null;
        }


        protected async Task<bool> Deslogar()
        {
            if (User != null)
            {
                await HttpContext.SignOutAsync("cookies");
            }

            return true;
        }


        protected long GetIdUsuarioLogado()
        {
            var claimUser = HttpContext?.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.NameIdentifier);

            if (claimUser != null)
            {
                return long.Parse(claimUser.Value.ToString());
            }
            else
                return -1;
        }



        protected string GetUserNameLogado()
        {
            var claimUser = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Name);

            if (claimUser != null)
            {
                return claimUser.Value.ToString();
            }
            else
                return "";
        }


        public bool IsAuthenticated()
        {
            return User?.Claims?.Any(p => p.Type == ClaimTypes.NameIdentifier) ?? false;
        }
    }
}
