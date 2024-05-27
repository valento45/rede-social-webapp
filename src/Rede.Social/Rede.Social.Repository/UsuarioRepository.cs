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

        public async Task<bool> ExisteUsuario(string email)
        {
            string query = $"select * from usuario_tb where UPPER(Email) like '{email.ToUpper()}'";
            var result = await base.QueryAsync<Usuario>(query);

            return result?.Any() ?? false;
        }

        public Task<bool> ExisteUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            string query = $"select * from usuario_tb";
            return await base.QueryAsync<Usuario>(query);
        }

        public async Task<string> GetMessage()
        {
            return base.GetMessage();
        }
    }
}
