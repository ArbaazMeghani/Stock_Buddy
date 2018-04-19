using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


class StockSymbols
{
    private HttpClient httpClient;
    private static StockSymbols stockSymbols;
    private static HashSet<String> allSymbols;

    private StockSymbols()
    {
        httpClient = new HttpClient();
        allSymbols = new HashSet<string>();
        requestAllSymbols();
    }

    private void requestAllSymbols()
    {
        String symbols = getRequest().Result;
        String[] individualSymbols = symbols.Split('\n');
        for (int i = 1; i < individualSymbols.Length; i++)
            allSymbols.Add(individualSymbols[i].Trim());
    }

    private async Task<String> getRequest()
    {
        String url = "https://api.iextrading.com/1.0/ref-data/symbols?filter=symbol&format=csv";
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
        HttpContent httpContent = httpResponseMessage.Content;
        return await httpContent.ReadAsStringAsync();
    }

    public static HashSet<String> getAllSymbols()
    {
        if (allSymbols == null)
            stockSymbols = new StockSymbols();
        return allSymbols;
    }
}
