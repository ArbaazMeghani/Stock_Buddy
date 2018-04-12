using StockBuddy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockBuddy
{
    public partial class Form1 : Form
    {
        Button currentClicked = null;
        Button graphTabClicked = null;
        public string input;
        Boolean mouseDown;
        Point currentMouseLocation;
        Profile savedProfile;
        Boolean purchasedClicked = false;
        System.Windows.Forms.Timer refreshTimer;

        public Form1()
        {
            InitializeComponent();
            savedProfile = new Profile();
            HashSet<String> symbols = StockSymbols.getAllSymbols();
            //foreach (String symbol in symbols)
                //searchResultList.Items.Add(symbol);
            stocksPanel.Hide();
            setUpSearchAutoFill();
            //purchasePanel.Hide();
            //watchlistPanel.Hide();
            amountLabel.Text = "$" + Convert.ToString(Settings.Default["Money"]);
            //Settings.Default["FirstTime"] = true;
            if (Convert.ToBoolean(Settings.Default["FirstTime"]))
            {
                userInput();
                Settings.Default["FirstTime"] = false;
                Settings.Default.Save();
            }
            current_time.Text = DateTime.Now.ToString("h:mm:ss");
            current_date.Text = DateTime.Now.ToString("MMMM dd\nyyyy");
            RefreshTimer_Setup();
            profilePicture_Click(null, null);
        }

        private void RefreshTimer_Setup()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5 * 60 * 1000;
            refreshTimer.Tick += RefreshTimer_Handler;
            refreshTimer.Enabled = true;
        }

        private void RefreshTimer_Handler(Object source, EventArgs e)
        {
            String name = this.searchResultList.Text.Trim();
            if (name == "")
                return;
            searchResultList_SelectedIndexChanged(null, null);
        }

        private void titlePane_mouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            currentMouseLocation = e.Location;
        }

        private void titlePane_mouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(e.X - currentMouseLocation.X  + this.Location.X, e.Y - currentMouseLocation.Y + this.Location.Y);
                this.Update();
            }
        }

        private void titlePane_mouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void handleNav_Click(Button clicked)
        {
            if (currentClicked != null)
                currentClicked.BackColor = Color.Transparent;

            currentClicked = clicked;
            currentClicked.BackColor = Color.Orange;
            
        }

        private void handleGraphTabs_Click(Button clicked)
        {
           
                if (graphTabClicked != null)
                {
                    graphTabClicked.BackColor = Color.Transparent;
                    graphTabClicked.ForeColor = Color.DarkOrange;
                }

                graphTabClicked = clicked;
                graphTabClicked.BackColor = Color.DarkOrange;
                graphTabClicked.ForeColor = Color.WhiteSmoke;
            
        }

        private void StocksBtn_Click(object sender, EventArgs e)
        {
            searchResultList.Items.Clear();
            HashSet<String> symbols = StockSymbols.getAllSymbols();
            foreach (String symbol in symbols)
                searchResultList.Items.Add(symbol);
            handleNav_Click((Button)sender);
            summary_panel.Hide();
            stocksPanel.Show();
            removeFromWatchlist.Hide();
            sellQTYLabel.Show();
            sellQTYTextbox.Show();
            addToWatchlist.Show(); 
            searchResultList.Height = 350;
            purchasedClicked = false;
            label11.Hide();
            label13.Hide();
            sharesOwned.Hide();
            purchasePrice.Hide();
        }

        private void purchasedBtn_Click(object sender, EventArgs e)
        {
            searchResultList.Items.Clear();
            var purchaseList = savedProfile.RetrievePurchases();

            foreach (var symbol in purchaseList)
            {
                searchResultList.Items.Add(symbol);
            }
            handleNav_Click((Button)sender);
            stocksPanel.Show();
            summary_panel.Hide();
            removeFromWatchlist.Hide();
            addToWatchlist.Hide();
            sellButton.Show();
            sellQTYLabel.Show();
            sellQTYTextbox.Show();
            searchResultList.Height = 425;
            purchasedClicked = true;
            label11.Show();
            label13.Show();
            sharesOwned.Show();
            purchasePrice.Show();

        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            purchasedClicked = false;

            searchResultList.Items.Clear();
            var watchList = savedProfile.RetrieveWatchList();

            foreach (var symbol in watchList)
            {
                searchResultList.Items.Add(symbol);
            }
            handleNav_Click((Button)sender);
            stocksPanel.Show();
            summary_panel.Hide();
            removeFromWatchlist.Show();
            removeFromWatchlist.Location = new Point(3,403);
            sellQTYLabel.Hide();
            sellButton.Hide();
            
            sellQTYTextbox.Hide();
            searchResultList.Height = 350;
            purchasedClicked = false;
            label11.Hide();
            label13.Hide();
            sharesOwned.Hide();
            purchasePrice.Hide();

        }

        private void userInput()
        {
            
            savedProfile.ClearProfile();
            double savedMoney = (double) Settings.Default["Money"];
            input = Microsoft.VisualBasic.Interaction.InputBox("How many dollars would you like to start off with?", "Initial amount", "0", -1, -1);
            //saving
            if ((input == "") || (input.All(char.IsDigit) == false))
            {
                savedMoney = (double)Settings.Default["Money"];
            }
            else
            {
                savedMoney = Convert.ToDouble(input);
            }

            Settings.Default["Money"] = savedMoney;
            Settings.Default["FirstTime"] = false;
            Settings.Default.Save();
            amountLabel.Text = "$" + Convert.ToString(Settings.Default["Money"]);
        }

        private void stocksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            if(currentClicked != null)
            {
                currentClicked.BackColor = Color.Transparent;
                currentClicked = null;
            }
            stocksPanel.Hide();
            summary_panel.Show();

            double stock_worth = 0.0;
            double net_gain = 0.0;

            SymbolGrid.Rows.Clear();
            price_chart.Series[0].Points.Clear();
            price_chart.Series[1].Points.Clear();
 
            List<String> purchases = savedProfile.RetrievePurchases();
            foreach (String symbol in purchases)
            {
                var single_purchase = savedProfile.RetieveSinglePurchase(symbol.Trim());
                double price_bought = single_purchase.Item3;
                int quantity = single_purchase.Item2;
                double current_price = 0.0;
                var thread = new Thread(() =>
                {
                    StatisticsDictionary stats = new StatisticsDictionary(symbol.Trim());
                    current_price = Convert.ToDouble(stats.getStat("latestPrice"));
                });
                thread.Start();
                thread.Join();
                if (price_bought < current_price)
                    SymbolGrid.Rows.Add(symbol, Resources.upward_green);
                else if(price_bought > current_price)
                    SymbolGrid.Rows.Add(symbol, Resources.downward_red);
                else
                    SymbolGrid.Rows.Add(symbol, Resources.neutral_yellow);

                stock_worth += current_price * quantity;
                net_gain += (current_price * quantity) - (price_bought * quantity);
                price_chart.Series[0].Points.AddXY(symbol, price_bought);
                price_chart.Series[1].Points.AddXY(symbol, current_price);
            }

            net_gain = Math.Round(net_gain, 3);
            stock_worth = Math.Round(stock_worth, 3);
            stock_worth_value_label.Text = stock_worth.ToString();
            net_gain_value_label.Text = net_gain.ToString();
        }

        private void addStatistics(String name)
        {

            String priceString ="",  openString = "", highString = "", lowString ="", yearHighString ="", yearLowString ="", volumeString = "",
                    avgVolString ="", marketcapString ="", PERatioString = "", dividendYieldString ="";


            if(purchasedClicked)
            {
                String symbol = this.searchResultList.Text.Trim();
                Tuple<String, int, double> purchase = savedProfile.RetieveSinglePurchase(symbol);
                if (purchase != null)
                {
                    sharesOwned.Text = purchase.Item2.ToString();
                    purchasePrice.Text = purchase.Item3.ToString();
                }
            }


            
            var thread = new Thread(
            () =>
            {
              
                StatisticsDictionary s = new StatisticsDictionary(name);
                priceString = s.getStat("latestPrice");
                openString = s.getStat("open");
                highString = s.getStat("high");
                lowString = s.getStat("low");
                yearHighString = s.getStat("week52High");
                yearLowString = s.getStat("week52Low");
                volumeString = s.getStat("latestVolume");
                avgVolString = s.getStat("avgTotalVolume");
                marketcapString = s.getStat("marketcap");
                PERatioString = s.getStat("peRatio");
                dividendYieldString = s.getStat("dividendYield");
            
            });
            thread.Start();
            thread.Join();

            double divYieldDouble = Convert.ToDouble(dividendYieldString);
            double marketCapDouble = Convert.ToDouble(marketcapString);
            double volumeDouble = Convert.ToDouble(volumeString);
            double avgVolDouble = Convert.ToDouble(avgVolString);


            divYieldDouble  = Math.Round(divYieldDouble, 3);
            dividendYieldString = Convert.ToString(divYieldDouble);

            if((marketCapDouble > 1000000) && marketCapDouble < 1000000000)
            {
                marketCapDouble /= 1000000;
                marketCapDouble = Math.Round(marketCapDouble, 0);
                marketcapString = Convert.ToString(marketCapDouble) + "M";
            }
            else if(marketCapDouble > 1000000000)
            {
                marketCapDouble /= 1000000000;
                marketCapDouble = Math.Round(marketCapDouble, 0);
                marketcapString = Convert.ToString(marketCapDouble) + "B";
            }

            if(volumeDouble > 1000000)
            {
                volumeDouble /= 1000000;
                volumeDouble = Math.Round(volumeDouble, 0);
                volumeString = Convert.ToString(volumeDouble) + "M";
            }

            if (avgVolDouble > 1000000)
            {
                avgVolDouble /= 1000000;
                avgVolDouble = Math.Round(avgVolDouble, 0);
                avgVolString = Convert.ToString(avgVolDouble) + "M";
            }


            OPEN.Text = openString;
            latestPrice.Text = priceString;
            HIGH.Text = highString;
            LOW.Text = lowString;
            yearHigh.Text = yearHighString;
            yearLow.Text = yearLowString;
            VOLUME.Text = volumeString;
            avgVolume.Text = avgVolString;
            marketCap.Text = marketcapString;
            peRatio.Text = PERatioString;
            divYield.Text = dividendYieldString;


        }



        private void addToGraph(List<Tuple<String, String>> dataTuple, List<Tuple<String, String, String>> dayTuple)
        {
            chart1.Series.Clear();
            chart1.Series.Add("1");
            chart1.Series["1"].ChartType = SeriesChartType.Line;
            chart1.Series["1"].Color = System.Drawing.Color.Red;

            int count = 1;

            if (dataTuple != null)
            {
                
                foreach (var i in dataTuple)
                {
                    chart1.Series["1"].Points.AddXY(count, i.Item2);
                    count++;
                }
            }

            else
            {
                foreach (var i in dayTuple)
                {
                    if (i.Item3 != "0")
                    {
                        chart1.Series["1"].Points.AddXY(count, i.Item3);
                        count++;
                    }
                }
            }

        }

        private void Day_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;
            List<Tuple<String, String,String>> dayTuple = new List<Tuple<String, String,String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dayTuple = parseObject.getOneDayOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(null, dayTuple);
        } 

        private void Month1_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;  
            List<Tuple<String, String>> dataTuple = new List<Tuple<String, String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dataTuple = parseObject.getOneMonthOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(dataTuple, null);
        }

        private void Month3_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;
            List<Tuple<String, String>> dataTuple = new List<Tuple<String, String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dataTuple = parseObject.getQuarterOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(dataTuple, null);
        }

        private void Month6_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;
            List<Tuple<String, String>> dataTuple = new List<Tuple<String, String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dataTuple = parseObject.getHalfYearOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(dataTuple, null);
        }

        private void Year1_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;
            List<Tuple<String, String>> dataTuple = new List<Tuple<String, String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dataTuple = parseObject.getOneYearOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(dataTuple, null);
        }

        private void Year5_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
            String name = chartName;
            List<Tuple<String, String>> dataTuple = new List<Tuple<String, String>>();
            ParsedData parseObject = new ParsedData();
            var thread = new Thread(
              () =>
              {
                  dataTuple = parseObject.getFiveYearsOfData(name);
              });
            thread.Start();
            thread.Join();

            addToGraph(dataTuple,null);
           // addStatistics(name);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            userInput();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.current_time.Text = DateTime.Now.ToString("hh:mm:ss");
            this.current_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void current_time_Click(object sender, EventArgs e)
        {

        }

        private void searchResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String name = "kjkj";
            
            if (searched == true)
            {
                chartName = this.searchText.Text.Trim();
                //searchResultList.ResetText();
                this.searchResultList.Text = String.Copy(chartName);
                Console.WriteLine(searchResultList.Text.Trim());
                Console.WriteLine("Name below. Text above");
                Console.WriteLine(chartName);
                searched = false; 
            }
            else {
                chartName = this.searchResultList.Text.Trim();
            }

            Console.WriteLine("Updated");
            if (graphTabClicked != null)
                graphTabClicked.PerformClick();
            else
            {
                Year5.PerformClick();
        
            }
            addStatistics(chartName);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void addToWatchlist_Click(object sender, EventArgs e)
        {
            String symbol = this.searchResultList.Text.Trim();

            //Console.WriteLine(symbol);

            savedProfile.DeleteWatchListItem(symbol);
            savedProfile.SaveWatchListItem(symbol);

            var temp =  savedProfile.RetrieveWatchList();

            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }
            
        }

        private void removeFromWatchlist_Click(object sender, EventArgs e)
        {
            String symbol = this.searchResultList.Text.Trim();

            savedProfile.DeleteWatchListItem(symbol);
        
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            String symbol = this.searchResultList.Text.Trim();
            if ((purchaseBoxTextbox.Text.ToString()) != "")
            {
                double buyPrice = Convert.ToDouble(latestPrice  .Text.ToString().Trim());
                double buyQuantity = Convert.ToDouble(purchaseBoxTextbox.Text.ToString());
                double subtractAmount = buyPrice * buyQuantity;
                if (savedProfile.subtractMoney(subtractAmount) == true)
                {
                    savedProfile.SavePurchase(symbol, Convert.ToInt32(purchaseBoxTextbox.Text), Convert.ToDouble(latestPrice.Text));
                    savedProfile.RetrievePurchases();
                    addStatistics(symbol);
                    purchaseBoxTextbox.Text = "";
                }
            }

        }

        private void sellButtton(object sender, EventArgs e)
        {
            int nSharesOwned = 0;
            int sellQuantity = 0;
            double sellPrice = 0;
            double totalPrice = 0;
            if (sharesOwned.Text.ToString() != "-" && sellQTYTextbox.Text.ToString() != "")
            {
                nSharesOwned = Convert.ToInt32(sharesOwned.Text.ToString());
                sellQuantity = Convert.ToInt32(sellQTYTextbox.Text.ToString());
                sellPrice = Convert.ToDouble(purchasePrice.Text.ToString());
                totalPrice = sellPrice * Convert.ToDouble(sellQuantity);


            }
            String symbol = this.searchResultList.Text.Trim();
            nSharesOwned -= sellQuantity;
            if (nSharesOwned > 0)
            {
                savedProfile.UpdatePurchase(symbol, nSharesOwned, sellPrice);
                addStatistics(symbol);
                savedProfile.addMoney(totalPrice);

            }
            else if (nSharesOwned == 0)
            {
                savedProfile.DeletePurchase(symbol);
                savedProfile.addMoney(totalPrice);

            }
            else if (nSharesOwned < 0)
            {
                MessageBox.Show("You cannot sell what you don't have.");

            }
            sellQTYTextbox.Text = " ";

            purchasedBtn.PerformClick();

        }

        void setUpSearchAutoFill()
        {
            searchText.KeyDown += new KeyEventHandler(searchText_KeyDown);
            searchText.Text = "";
            searchText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            var symbols = StockSymbols.getAllSymbols();

            foreach (var symbol in symbols)
            {
         
                collection.Add(symbol);     
            }

            searchText.AutoCompleteCustomSource = collection; 

        }
        Boolean searched = false;
        String chartName = "";
        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            
            

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.LButton)
            {
                searched = true; 
                //this.searchResultList.Text = this.searchText.Text.Trim();
                Console.Write(searchResultList.Text);
                Console.WriteLine(this.searchText.Text.Trim());
                searchResultList_SelectedIndexChanged(null, null);
            }

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}