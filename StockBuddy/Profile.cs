using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


class Profile
{
    private DatabaseManager databaseManager;

    public Profile()
    {
        databaseManager = new DatabaseManager();
    }

    public void ClearProfile()
    {
        String clearWatchListQuery = "DELETE FROM WatchList;";
        String clearPurhcaseListQuery = "DELETE FROM PurchaseList;";
        databaseManager.SimpleQueryExecution(clearPurhcaseListQuery);
        databaseManager.SimpleQueryExecution(clearWatchListQuery);
    }

    public void SaveWatchListItem(String symbol)
    {
        String addWatchListItemQuery = "INSERT INTO WatchList (Symbol) VALUES (@Symbol);";
        databaseManager.UpdateTableItem(symbol, addWatchListItemQuery);
    }

    public void DeleteWatchListItem(String symbol)
    {
        String deleteWatchListItemQuery = "DELETE FROM WatchList WHERE Symbol =  @Symbol;";
        databaseManager.UpdateTableItem(symbol, deleteWatchListItemQuery);
    }


    public List<String> RetrieveWatchList()
    {
        String query = "SELECT * FROM WatchList;";
        DataTable watchTable = databaseManager.SelectQuery(query);
        List<String> watchList = new List<string>();
        DataTableReader dataTableReader = watchTable.CreateDataReader();
        while(dataTableReader.Read())
        {
            watchList.Add(dataTableReader[1].ToString());
        }
        watchTable.Dispose();
        return watchList;
    }

    public void SavePurchase(String symbol, int quantity, double price)
    {
        String addPurchaseListItemQuery = "INSERT INTO PurchaseList (Symbol,Quantity,Price) VALUES (@Symbol,@Quantity,@Price);";
        databaseManager.UpdatePurchaseListItem(symbol, quantity, price, addPurchaseListItemQuery);
    }

    public void UpdatePurchase(String symbol, int quantity, double price)
    {
        String updatePurchaseListItemQuery = "UPDATE PurchaseList SET Quantity = @Quantity WHERE Symbol = @Symbol AND Price = @Price;";
        databaseManager.UpdatePurchaseListItem(symbol, quantity, price, updatePurchaseListItemQuery);
    }

    public Tuple<String, int, double> RetieveSinglePurchase(String symbol)
    {
        String query = "SELECT * FROM PurchaseList WHERE Symbol = @Symbol";
        DataTable purchaseTable = databaseManager.SingleSelectQuery(query, symbol);
        DataTableReader dataTableReader = purchaseTable.CreateDataReader();
        dataTableReader.Read();
        if (!dataTableReader.HasRows)
            return null;
        Tuple<String, int, double> purchase = new Tuple<string, int, double>(
            Convert.ToString(dataTableReader[1]),
            Convert.ToInt32(dataTableReader[2]), 
            Convert.ToDouble(dataTableReader[3]));
        purchaseTable.Dispose();
        return purchase;
    }

    public void DeletePurchase(String symbol)
    {
        String deletePurchaseListItemQuery = "DELETE FROM PurchaseList WHERE Symbol = @Symbol;";
        databaseManager.UpdateTableItem(symbol, deletePurchaseListItemQuery);
    }

    public List<String> RetrievePurchases()
    {
        String query = "SELECT * FROM PurchaseList;";
        DataTable purchaseTable = databaseManager.SelectQuery(query);
        List<String> purchaseList = new List<string>();
        DataTableReader dataTableReader = purchaseTable.CreateDataReader();
        while(dataTableReader.Read())
        {
            purchaseList.Add(dataTableReader[1].ToString());
        }
        purchaseTable.Dispose();
        return purchaseList;
    }
}
