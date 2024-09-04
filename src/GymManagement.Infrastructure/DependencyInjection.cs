namespace GymManagement.Infrastructure;

using GygManagement.Infrastructure.Subscriptions.Persistence;
using GymManagement.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{

  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    services.AddScoped<ISubscriptionsRepository, SubscriptionsRepository>();

    return services;
  }
}
