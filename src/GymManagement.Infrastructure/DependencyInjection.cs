namespace GymManagement.Infrastructure;

using GygManagement.Infrastructure.Common.Persistence;
using GygManagement.Infrastructure.Subscriptions.Persistence;
using GymManagement.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{

  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    services.AddDbContext<GymManagementDbContext>(options => options.UseSqlite("Data Source = GymManagement.db"));

    services.AddScoped<ISubscriptionsRepository, SubscriptionsRepository>();

    return services;
  }
}
