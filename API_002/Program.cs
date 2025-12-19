using System.Text.Json;

namespace API_002
{

    public class CoincheckJson
    {
        public float last { get; set; }
        public int timestamp { get; set; }

        // 現在使用しない
        // public float bid { get; set; }
        // public float ask { get; set; }
        // public float high { get; set; }
        // public float low { get; set; }
        // public float volume { get; set; }
    }



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
                    Console.WriteLine($"げんざいBTCかかくは{convertedApiResponse.last:N0}JPYです。");
                    Console.WriteLine($"げんざいじこくは{dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss")}です。");
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

            Console.WriteLine("BTC/JPY げんざいかかくしょうかい");

            ApiService apiService = new ApiService();
            await apiService.GetBtcJpyTicker();
        }
    }
}