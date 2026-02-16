using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
public static class SortedDic
{
    public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
    public static SortedDictionary<string, long> FindItemDetails(long SoldCount)
    {
        var res = new SortedDictionary<string, long>();
        foreach (var item in itemDetails)
        {
            if (item.Value == SoldCount)
            {
                res[item.Key] = item.Value;   
            }
        }
        return res;
    }
    public static List<string> FindMinandMaxSoldItems()
    {
        var res = new List<string>();
        if(itemDetails.Count == 0)
        {
            return res;
        }
        long min = itemDetails.Values.Min();
        long max = itemDetails.Values.Max();
        res.Add(itemDetails.First(x => x.Value == min).Key);
        res.Add(itemDetails.First(x => x.Value == max).Key);
        return res;
    }
    public static Dictionary<string, long> SortByCount()
    {
        return itemDetails.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }
}
