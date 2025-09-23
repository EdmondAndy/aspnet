namespace MyStockApp.ServiceContracts
{
    public interface IFinnhubService
    { 
        Task<Dictionary<string, object>?> GetStockPriceQuote(string symbol);
    }
}