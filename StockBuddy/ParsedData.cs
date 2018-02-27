using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ParsedData
{
    private List<Tuple<String,String>> dataList;
    private List<Tuple<String, String, String>> dataDayList;
    private String data, type; 

    public ParsedData()
    {
        dataList = new List<Tuple<string, string>>();
        dataDayList = new List<Tuple<String, String,String>>();
    }

    private void parseData()
    {

        data = Regex.Replace(data, @"\t|\n|\r", ",");
        data = Regex.Replace(data, @",,", ",");
        String[] parsedData = data.Split(',');


        if (this.type != "1d") {
            for (int i = 2; i < parsedData.Length; i = i + 2)
            {

                dataList.Add(new Tuple<string, string>(parsedData[i], parsedData[i + 1]));

            }
        }
        else
        {
            for (int i = 3; i < parsedData.Length; i = i + 3)
            {
                try
                {
                    dataDayList.Add(new Tuple<string, string, string>(parsedData[i], parsedData[i + 1], parsedData[i + 2]));
                }
                catch
                {
                    // Do nothing. 
                }
            }
        }

    }

    public List<Tuple<String, String>> getFiveYearsOfData(String symbol)
    {
        this.data = GraphData.getGraphData().fiveYears(symbol);
        parseData();


        return dataList; 
    }

    public List<Tuple<String, String>> getOneYearOfData(String symbol)
    {
        this.data = GraphData.getGraphData().year(symbol);
        parseData();


        return dataList;
    }

    public List<Tuple<String, String>> getHalfYearOfData(String symbol)
    {
        this.data = GraphData.getGraphData().halfYear(symbol);
        parseData();


        return dataList;
    }

    public List<Tuple<String, String>> getQuarterOfData(String symbol)
    {
        this.data = GraphData.getGraphData().quarter(symbol);
        parseData();


        return dataList;
    }

    public List<Tuple<String, String>> getOneMonthOfData(String symbol)
    {
        this.data = GraphData.getGraphData().month(symbol);
        parseData();


        return dataList;
    }

    public List<Tuple<String, String, String>> getOneDayOfData(String symbol)
    {
        this.data = GraphData.getGraphData().intraday(symbol);
        this.type = "1d";
        parseData();


        return dataDayList;
    }



}
