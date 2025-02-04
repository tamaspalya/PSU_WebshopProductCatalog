﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Webshop.Application;
using Webshop.Application.Contracts;

namespace Webshop.Customer.Application
{
    public static class CustomerApplicationServiceRegistration
    {
        public static IServiceCollection AddCustomerApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IDispatcher>(sp => new Dispatcher(sp.GetService<IMediator>()));

            return services;
        }
    }
}
