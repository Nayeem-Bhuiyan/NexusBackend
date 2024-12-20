using NBSoft.Application.Interfaces;
using NBSoft.Domain.Common;
using NBSoft.Domain.Common.Interfaces;
using NBSoft.Infrastructure.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NBSoft.Application.Interfaces.Email;
using NBSoft.Application.Interfaces.DateFunctions;

namespace NBSoft.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>();
        }
    }
}
