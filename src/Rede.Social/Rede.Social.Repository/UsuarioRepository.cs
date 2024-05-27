using Rede.Social.Domain.Authorization;
using Rede.Social.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede.Social.Repository
{
    public class UsuarioRepository : RepositoryBase, IUsuarioRepository
    {


        public UsuarioRepository(IDbConnection dbConnection) : base(dbConnection)
        {

        }

        public Task<Usuario> IncluirUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Excluir(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExisteUsuario(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExisteUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetMessage()
        {
            return base.GetMessage();
        }
    }
}
