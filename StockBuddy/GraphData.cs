using System;
using System.Threading.Tasks;
using System.Net.Http;

public class GraphData
{
    private HttpClient httpClient;
    private static GraphData graphData;

    private GraphData()
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
        String base_url;
        if (type.Equals("1d"))
            base_url = "https://api.iextrading.com/1.0/stock/{0}/chart/{1}?filter=date,label,average&format=csv";
        else
            base_url = "https://api.iextrading.com/1.0/stock/{0}/chart/{1}?filter=date,close&format=csv";
        return String.Format(base_url, symbol, type);
    }

    public String fiveYears(String symbol)
    {
        String url = formatURL(symbol, "5y");
        return getRequest(url).Result;
    }

    public String year(String symbol)
    {
        String url = formatURL(symbol, "1y");
        return getRequest(url).Result;
    }

    public String halfYear(String symbol)
    {
        String url = formatURL(symbol, "6m");
        return getRequest(url).Result;
    }

    public String quarter(String symbol)
    {
        String url = formatURL(symbol, "3m");
        return getRequest(url).Result;
    }

    public String month(String symbol)
    {
        String url = formatURL(symbol, "1m");
        return getRequest(url).Result;
    }

    public String intraday(String symbol)
    {
        String url = formatURL(symbol, "1d");
        return getRequest(url).Result;
    }

    public static GraphData getGraphData()
    {
        if (graphData == null)
            graphData = new GraphData();
        return graphData;
    }
}