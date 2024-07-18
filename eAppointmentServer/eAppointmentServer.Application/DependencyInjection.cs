﻿using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
            } );
            return services;
        }
    }
}
