using System;
using API_002.Services;
using API_002.Utils;

namespace API_002
{
    class Program
    {
        static async Task Main()
        {
            ConsolePrinter.PrintHeader();

            ApiService apiService = new ApiService();
            await apiService.GetBtcJpyTicker();
        }
    }
}