using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


class Profile
{
    public Profile()
    {

    }

    public void ClearProfile()
    {
        String clearWatchListQuery = "DELETE FROM WatchList;";
        String clearPurhcaseListQuery = "DELETE FROM PurchaseList;";
    }

    public void SaveWatchListItem(String symbol)
    {
        String addWatchListItemQuery = "INSERT INTO WatchList (Symbol) VALUES (@Symbol);";
    }

    public void DeleteWatchListItem(String symbol)
    {
        String deleteWatchListItemQuery = "DELETE FROM WatchList WHERE Symbol =  @Symbol;";
    }

    public List<String> RetrieveWatchList()
    {
        String query = "SELECT * FROM WatchList;";
        DataTable watchTable = null; //TODO
        List<String> watchList = new List<string>();
        DataTableReader dataTableReader = watchTable.CreateDataReader();
        while(dataTableReader.Read())
        {
            watchList.Add(dataTableReader[0].ToString());
        }

        return watchList;
    }

    public void SavePurchase(String symbol, int quantity, double price)
    {
        String addPurchaseListItemQuery = "INSERT INTO PurchaseList (Symbol,Quantity,Price) VALUES (@Symbol,@Quantity,@Price);";
    }

    public void UpdatePurchase(String symbol, int quantity, double price)
    {
        String updatePurchaseListItemQuery = "UPDATE PurchaseList SET Quantity = @Quantity WHERE Symbol = @Symbol AND Price = @Price;";
    }

    public void DeletePurchase(String symbol)
    {
        String deletePurchaseListItemQuery = "DELETE FROM PurchaseList WHERE Symbol =  @Symbol;";
    }

    public List<Tuple<String, int, double>> RetrievePurchases()
    {
        String query = "SELECT * FROM PurchaseList;";
        DataTable purchaseTable = null; //TODO
        List<Tuple<String, int, double>> purchaseList = new List<Tuple<string, int, double>>();
        DataTableReader dataTableReader = purchaseTable.CreateDataReader();
        while(dataTableReader.Read())
        {
            for(int i = 0; i < dataTableReader.FieldCount; i++)
            {
                Tuple<String, int, double> item = new Tuple<string, int, double>(dataTableReader[0].ToString(), Convert.ToInt32(dataTableReader[1]), Convert.ToDouble(dataTableReader[2]));
                purchaseList.Add(item);

            }
        }

        return purchaseList;
    }
}
