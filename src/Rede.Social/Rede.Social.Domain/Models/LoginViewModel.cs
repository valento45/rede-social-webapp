using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Rede.Social.Security;

namespace Rede.Social.Domain.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PasswordHash
        {
            get
            {
                return Security.Security.Encrypt(Senha);
            }
        }
        public string Message { get; set; }

        public bool LembrarMe { get; set; }

        public LoginViewModel()
        {

        }
    }
}
