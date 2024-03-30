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

    public List<CategoryProduct> GetCategoryProducts()
    {
        var sql = @"select c.name as CategoryName,p.name as ProductName
                   from categories as c
                   join products as p on c.id=p.categoryid ";
        var result = _context.Connection().Query<CategoryProduct>(sql).ToList();
        return result;
    }

    public List<CategoryAverage> GetCategoryAverage()
    { var sql = @"select c.name as CategoryName,AVG(p.price) as ProcuctAvg
                   from categories as c
                   join products as p on c.id=p.categoryid
                   group by c.name";
        var result = _context.Connection().Query<CategoryAverage>(sql).ToList();
        return result;
    }

    public List<UserPrice> GetUserPrice()
    {
        var sql = @"select u.username as UserName,SUM(p.price) as Total
                   from users as u
                   join markets as m on u.id=m.userid
                   join products as p on m.id=p.marketid
                   group by u.username";
        var result = _context.Connection().Query<UserPrice>(sql).ToList();
        return result;
    }
}