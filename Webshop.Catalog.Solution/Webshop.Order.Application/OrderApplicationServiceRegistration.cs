using MediatR;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Webshop.Application.Contracts;
using Webshop.Application;

namespace Webshop.Order.Application
{
    public static class OrderApplicationServiceRegistration
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
