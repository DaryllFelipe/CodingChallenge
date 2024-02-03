using Coding.Challenge.Domain.Interfaces.Repositories;
using Coding.Challenge.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
namespace Coding.Challenge.Repositories;
public static class DependencyContainer
{
    public static IServiceCollection AddCodingChallengeRepositories(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingConfig));
        services.AddScoped<IBookRepository, BookRepository>();
        return services;
    }
}