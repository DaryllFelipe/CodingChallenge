using Microsoft.Extensions.DependencyInjection;
using Coding.Challenge.Repositories;
using Coding.Challenge.Domain;

namespace Coding.Challenge.InversionOfControl
{
    public static class ServicesDependencies
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddCodingChallengeRepositories();
            services.AddCodingChallengeDomain();
            return services;
        }
    }   
}
