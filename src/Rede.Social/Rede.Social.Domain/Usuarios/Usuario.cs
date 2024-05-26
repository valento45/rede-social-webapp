using Rede.Social.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Domain.Usuarios
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool AutenticaDoisFatores { get; set; }
        public string Celular { get; set; }
        public bool EmailVerificado { get; set; }
        private Pessoa _pessoa { get; set; }
        public Pessoa Pessoa
        {
            get
            {
                if(_pessoa == null)
                    _pessoa = new Pessoa(); 

                return _pessoa;
            }
            set
            {
                _pessoa = value;
            }
        }


        public Usuario()
        {

        }
    }
}
