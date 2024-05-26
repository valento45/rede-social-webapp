using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Domain.Bases
{
    public class Pessoa
    {

        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string RG { get;}
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }

        public Pessoa()
        {
            
        }



    }
}
