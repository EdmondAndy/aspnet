using Microsoft.AspNetCore.Mvc;
using MyStockApp.Services;
using MyStockApp.Models;
using Microsoft.Extensions.Options;

namespace MyStockApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly FinnhubService _finnhubService;
        private readonly IConfiguration _configuration;

        public HomeController(FinnhubService finnhubService, IConfiguration configuration)
        {
            _finnhubService = finnhubService;
            _configuration = configuration;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(_configuration["TradingOptions:DefaultStockSymbol"]))
            {
                _configuration["TradingOptions:DefaultStockSymbol"] = "AAPL";
            }
            Dictionary<string, object>? responseDictionary = await _finnhubService.GetStockPriceQuote(_configuration["TradingOptions:DefaultStockSymbol"]!);

            Stock stock = new Stock()
            {
                Symbol = _configuration["TradingOptions:DefaultStockSymbol"],
                CurrentPrice = Convert.ToDouble(responseDictionary!["c"].ToString()),
                LowestPrice = Convert.ToDouble(responseDictionary!["l"].ToString()),
                HighestPrice = Convert.ToDouble(responseDictionary!["h"].ToString()),
                OpenPrice = Convert.ToDouble(responseDictionary!["o"].ToString())
            };
            return View(stock);
        }
    }
}