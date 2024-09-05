using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GygManagement.Infrastructure.Common.Persistence;

public class GymManagementDbContext : DbContext
{

  public DbSet<Subscription> Subscriptions { get; set; } = null!;

  public GymManagementDbContext(DbContextOptions options) : base(options)
  {
  }
}
