using Domain.Models;

namespace Infrastructure.Services.QueryService;

public interface IQueryService
{
    List<UserMarkets> GetUserMarkets();
}