using Rede.Social.Domain.Authorization;
using Rede.Social.Repository.Interfaces;
using Rede.Social.Service.Interfaces;
using Rede.Social.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> IncluirUsuario(Usuario usuario)
        {
            return await _usuarioRepository.IncluirUsuario(usuario);
        }

        public async Task<MessageResponse> Atualizar(Usuario usuario)
        {          
            if (usuario == null || usuario.IdUsuario <= 0)
                return new MessageResponse((int)HttpStatusCode.BadRequest, "Usuário inválido");


            var result = await _usuarioRepository.Atualizar(usuario);


            if (result)
                return new MessageResponse((int)HttpStatusCode.OK, "Usuário atualizado com sucesso!");

            else
                return new MessageResponse((int)HttpStatusCode.InternalServerError, await _usuarioRepository.GetMessage());

        }

        public async Task<MessageResponse> Excluir(int idUsuario)
        {
            if (!await _usuarioRepository.ExisteUsuario(idUsuario))
                return new MessageResponse((int)HttpStatusCode.BadRequest, "Não existe usuário para exclusão.");

            else
            {
                var result = await _usuarioRepository.Excluir(idUsuario);

                if (result)
                    return new MessageResponse((int)HttpStatusCode.OK, "Usuário excluído com sucesso!");
                else
                    return new MessageResponse((int)HttpStatusCode.BadRequest, await _usuarioRepository.GetMessage());
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _usuarioRepository.GetAll();
        }

        public async Task<bool> ExisteUsuario(string email)
        {
            return await _usuarioRepository.ExisteUsuario(email);
        }
    }
}
