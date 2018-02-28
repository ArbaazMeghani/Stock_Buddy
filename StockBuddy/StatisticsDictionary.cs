using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StatisticsDictionary
{
    private Dictionary<String, String> statistics;
    String symbol;

    public StatisticsDictionary(String symbol)
    {
        statistics = new Dictionary<string, string>();
        this.symbol = symbol;
        retrieveStatistics();
    }

    private void retrieveStatistics()
    {
        Tuple<String, String> statStrings = Statistics.getStatistics().statistics(symbol);
        addToDictionary(statStrings.Item1);
        addToDictionary(statStrings.Item2);
    }

    private void addToDictionary(String data)
    {
        String[] splitData = data.Split('\n');
        String[] dataOnly = splitData[1].Split(',');
        String[] headersOnly = splitData[0].Split(',');
        for (int i = 0; i < dataOnly.Length; i++)
            statistics.Add(headersOnly[i], dataOnly[i]);
    }

    public List<String> allKeywords()
    {
        return statistics.Keys.ToList();
    }

    public String getStat(String keyword)
    {
        try
        {
            return statistics[keyword];
        }
        catch(Exception e)
        {
            return "N/A";
        }
    }
}
