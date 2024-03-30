using Domain.Models;

namespace Infrastructure.Services.QueryService;

public interface IQueryService
{
    List<UserMarkets> GetUserMarkets();
    List<CategoryProduct> GetCategoryProducts();
    List<CategoryAverage> GetCategoryAverage();
    List<UserPrice> GetUserPrice();
}