
using Rede.Social.Domain.Authorization;
using Rede.Social.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> IncluirUsuario(Usuario usuario);

        Task<MessageResponse> Atualizar(Usuario usuario);
        Task<MessageResponse> Excluir(int idUsuario);
        Task<IEnumerable<Usuario>> GetAll();
        Task<bool> ExisteUsuario(string email);

    }
}
