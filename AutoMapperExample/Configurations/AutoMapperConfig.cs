using AutoMapper;
using AutoMapperExample.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace AutoMapperExample.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));


            services.AddAutoMapper(typeof(EntityToViewModelMappingProfile));
        }
    }
}
