using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.QueryService;

public class QueryService : IQueryService
{
    private readonly DapperContext _context;

    public QueryService()
    {
        _context = new DapperContext();
    }

    public List<UserMarkets> GetUserMarkets()
    {
        var sql =
            @"select  u.username as UserName,m.market_name as MarketName
             from users as  u
            join markets as m on u.id=m.userid";

         var result = _context.Connection().Query<UserMarkets>(sql).ToList();

         return result;
        
    }
}