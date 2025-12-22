using System;

namespace API_002.CoincheckGet
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
}
