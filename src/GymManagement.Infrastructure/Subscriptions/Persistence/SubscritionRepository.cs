using GygManagement.Infrastructure.Common.Persistence;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;

namespace GygManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionsRepository : ISubscriptionsRepository
{
  private readonly GymManagementDbContext _dbContext;

  public SubscriptionsRepository(GymManagementDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task AddSubscriptionAsync(Subscription subscription)
  {
    await _dbContext.Subscriptions.AddAsync(subscription);
    await _dbContext.SaveChangesAsync();
  }

  public async Task<Subscription?> GetByIdAsync(Guid id)
  {
    return await _dbContext.Subscriptions.FindAsync(id);
  }
}
