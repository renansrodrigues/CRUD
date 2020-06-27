using Microsoft.Extensions.DependencyInjection;
using System;
using Visums.Application.AppServices;
using Visums.Application.Interfaces.Usuario;
using Visums.Domain.Core.Handler;
using Visums.Domain.Interface;
using Visums.Domain.Repository;
using Visums.Infra.Data.Repository;
using Visums.Infra.Data.UoW;

namespace Visums.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {

        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IMediatorHadler>();

            // Application
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();

            //Data
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


        }


    }
}
