﻿using Microsoft.Extensions.DependencyInjection;

namespace StructureMap
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddStructureMap(this IServiceCollection services)
        {
            return AddStructureMap(services, registry: null);
        }

        public static IServiceCollection AddStructureMap(this IServiceCollection services, IRegistry registry)
        {
            return services.AddSingleton<IServiceProviderFactory<IRegistry>>(new StructureMapServiceProviderFactory(registry));
        }
    }
}