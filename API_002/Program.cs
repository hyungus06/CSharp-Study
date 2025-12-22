using System;
using System.Text.Json;
using API_002.CoincheckGet;

namespace API_002
{
    class ApiService
    {
        public static readonly HttpClient client = new HttpClient();
        public string baseUrl = "https://coincheck.com/api/ticker?pair=btc_jpy";

        public async Task GetBtcJpyTicker()
        {
            try
            {
                string apiResponse = await client.GetStringAsync(baseUrl);
                CoincheckJson? convertedApiResponse = JsonSerializer.Deserialize<CoincheckJson>(apiResponse);

                if (convertedApiResponse != null)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(convertedApiResponse.timestamp).AddHours(9); // UTC+9 時間設定

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"げんざいBTCかかくは{convertedApiResponse.last:N0}JPYです。");
                    Console.WriteLine($"げんざいじこくは{dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss")}です。");
                    Console.WriteLine("-------------------------------------------");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"エラーがはっせいしました。{error.Message}");
            }
        }
    }

    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("|BTC/JPY げんざいかかくしょうかい|");
            Console.WriteLine("==================================");

            ApiService apiService = new ApiService();
            await apiService.GetBtcJpyTicker();
        }
    }
}