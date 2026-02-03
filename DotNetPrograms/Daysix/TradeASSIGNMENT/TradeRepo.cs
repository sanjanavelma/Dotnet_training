using System;
using System.Collections.Generic;
public class TradeRepository<T> where T : Trade
    {
        private List<T> trades = new List<T>();
        public static int tradeCount = 0;
        public void AddTrade(T trade)
        {
            
            trades.Add(trade);
            tradeCount++;
            TradeAnalytics.TrackTT++;
    }
        public void DisplayTrade()
    {
        Console.WriteLine("Trades in Repository: ");
        foreach (var t in trades)
        {
            Console.WriteLine(t);
        }
    }
}