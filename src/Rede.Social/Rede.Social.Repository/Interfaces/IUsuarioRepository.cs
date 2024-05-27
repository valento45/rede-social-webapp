using Rede.Social.Domain.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Repository.Interfaces
{
    public interface IUsuarioRepository
    {


        Task<Usuario> IncluirUsuario(Usuario usuario);

        Task<bool> Atualizar(Usuario usuario);
        Task<bool> Excluir(int idUsuario);  
        Task<IEnumerable<Usuario>> GetAll();

        /// <summary>
        /// Verifica se existe usuario por email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> ExisteUsuario(string email);    

        /// <summary>
        /// Verifica se existe usuario por ID
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        Task<bool> ExisteUsuario(int idUsuario);

        Task<string> GetMessage();
    }
}
