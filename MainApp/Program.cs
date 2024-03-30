using Infrastructure.Services.QueryService;

var service= new QueryService();

var list= service.GetUserMarkets();


foreach (var um in list)
{
    Console.WriteLine($"UserName:{um.UserName} market: {um.MarketName}");
}