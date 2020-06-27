using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using Visums.Application.AutoMapper;

namespace Visums.Services.Api.Configurations
{
    public static class AutoMapperSetup
    {

        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }

    }
}
