using System;
using API_002.Services;

namespace API_002
{
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