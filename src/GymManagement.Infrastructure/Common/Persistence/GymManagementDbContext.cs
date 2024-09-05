using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GygManagement.Infrastructure.Common.Persistence;

public class GymManagementDbContext : DbContext, IUnitOfWork
{

  public DbSet<Subscription> Subscriptions { get; set; } = null!;

  public GymManagementDbContext(DbContextOptions options) : base(options)
  {
  }

  public async Task CommitChangesAsync() {
    await base.SaveChangesAsync();
  }
}
