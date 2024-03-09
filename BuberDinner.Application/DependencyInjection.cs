﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(s =>
                s.RegisterServicesFromAssemblies(typeof(DependencyInjection).GetTypeInfo().Assembly));

            return services;
        }
    }
}
