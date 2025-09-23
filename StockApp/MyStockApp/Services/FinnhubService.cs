using System.Threading.Tasks;
using System.Text.Json;
using MyStockApp.ServiceContracts;

namespace MyStockApp.Services
{
    public class FinnhubService : IFinnhubService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public FinnhubService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<Dictionary<string, object>?> GetStockPriceQuote(string symbol)
        {
            using (HttpClient httpClient = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(
                    HttpMethod.Get,
                    new Uri($"https://finnhub.io/api/v1/quote?symbol={symbol}&token={_configuration["FinnhubToken"]}")
                );

                HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                Stream stream = httpResponseMessage.Content.ReadAsStream();

                StreamReader streamReader = new StreamReader(stream);

                string responseBody = await streamReader.ReadToEndAsync();

                Dictionary<string, object>? responseDictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(responseBody);

                if (responseDictionary == null || responseDictionary.Count == 0)
                {
                    throw new Exception("Failed to get stock price quote.");
                }

                if (responseDictionary.ContainsKey("error"))
                {
                    throw new Exception(responseDictionary["error"].ToString());
                }

                return responseDictionary;
            }
        }
    }
}