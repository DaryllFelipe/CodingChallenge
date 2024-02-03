using Coding.Challenge.Domain.Interfaces.Services;
using Coding.Challenge.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Coding.Challenge.Domain;
public static class DependencyContainer
{
    public static IServiceCollection AddCodingChallengeDomain(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        return services;
    }
}