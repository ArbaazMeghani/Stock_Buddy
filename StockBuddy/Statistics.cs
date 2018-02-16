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
            filter = "?filter=open,high,low,latestVolume,avgTotalVolume,peRatio,week52High,week52Low";
        else
            filter = "?filter=marketcap,dividendYield";
        return String.Format(base_url, symbol, type, filter);
    }

    public String statistics(String symbol)
    {
        String url1 = formatURL(symbol, "quote");
        String url2 = formatURL(symbol, "stats");
        return getRequest(url1).Result + "\n\n" +getRequest(url2).Result;
    }

    public static Statistics getStatistics()
    {
        if (stats == null)
            stats = new Statistics();
        return stats;
    }
}
