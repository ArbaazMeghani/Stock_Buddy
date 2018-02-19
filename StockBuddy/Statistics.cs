using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

public class Statistics
{
    private HttpClient httpClient;
    private static Statistics stats;

    private Statistics()
    {
        httpClient = new HttpClient();
    }

    private async Task<String> getRequest(String url)
    {
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
        HttpContent httpContent = httpResponseMessage.Content;
        return await httpContent.ReadAsStringAsync();
    }

    private String formatURL(String symbol, String type)
    {
        String base_url = "https://api.iextrading.com/1.0/stock/{0}/{1}/{2}&format=csv";
        String filter = "";
        if (type.Equals("quote"))
            filter = "?filter=open,high,low,latestPrice,latestVolume,avgTotalVolume,peRatio,week52High,week52Low";
        else
            filter = "?filter=marketcap,dividendYield";
        return String.Format(base_url, symbol, type, filter);
    }

    public Tuple<String, String> statistics(String symbol)
    {
        String url1 = formatURL(symbol, "quote");
        String url2 = formatURL(symbol, "stats");
        String url1Data = getRequest(url1).Result;
        String url2Data = getRequest(url2).Result;
        return new Tuple<String, String>(url1Data, url2Data);
    }

    public static Statistics getStatistics()
    {
        if (stats == null)
            stats = new Statistics();
        return stats;
    }
}
