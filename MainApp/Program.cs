using Infrastructure.Services.QueryService;

var service= new QueryService();

var listCategoryProducts= service.GetCategoryProducts();

foreach (var um in listCategoryProducts)
{
    Console.WriteLine($"{um.ProductName}  {um.CategoryName}");
}

var listUserMarkets= service.GetUserMarkets();

foreach (var um in listUserMarkets)
{
    Console.WriteLine($"{um.UserName}  {um.MarketName}");
}

var listCategoryAvg= service.GetCategoryAverage();

foreach (var um in listCategoryAvg)
{
    Console.WriteLine($"{um.CategoryName}  {um.ProductAvg}");
}

var listUserPrice= service.GetUserPrice();

foreach (var um in listUserPrice)
{
    Console.WriteLine($"{um.UserName}  {um.Total}");
}