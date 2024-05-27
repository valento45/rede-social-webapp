
using Npgsql;
using Rede.Social.Repository;
using Rede.Social.Repository.Interfaces;
using Rede.Social.Service;
using Rede.Social.Service.Interfaces;
using Rede.Social.WebApp.Configuration.Exceptions;
using System.Data;
using System.Diagnostics;

namespace Rede.Social.WebApp.Configuration
{
    public static class InjectDependences
    {

        public static void InjetarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllersWithViews();

            services.AddDataBaseConfiguration(configuration);
            services.AddRepositorys();
            services.AddServices();


            
        }

        private static void AddRepositorys(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

        }


        private static void AddServices(this IServiceCollection services)
        {

            services.AddTransient<IUsuarioService, UsuarioService>();
        }

        private static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = "";

            if (!Debugger.IsAttached)
                connectionString = configuration.GetConnectionString("Production");

            else
                connectionString = configuration.GetConnectionString("Postgres");


            NpgsqlConnection con = new NpgsqlConnection(connectionString);

            services.AddSingleton<IDbConnection>(con);
        }
    }
}
