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
        public Form1()
        {
            InitializeComponent();
            HashSet<String> symbols = StockSymbols.getAllSymbols();
            foreach (String symbol in symbols)
                searchResultList.Items.Add(symbol);
            stocksPanel.Hide();
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
            handleNav_Click((Button)sender);
            //purchasePanel.Hide();
            //watchlistPanel.Hide();
            summary_panel.Hide();
            stocksPanel.Show();
            removeFromWatchlist.Hide();
            sellQTYLabel.Show();
            sellQTYTextbox.Show();
            addToWatchlist.Show(); 
            searchResultList.Height = 350;
        }

        private void purchasedBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Show();
            summary_panel.Hide();
            removeFromWatchlist.Hide();
            addToWatchlist.Hide();
            sellQTYLabel.Show();
            sellQTYTextbox.Show();
            searchResultList.Height = 425; 
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Show();
            summary_panel.Hide();
            removeFromWatchlist.Show();
            removeFromWatchlist.Location = new Point(3,403);
            sellQTYLabel.Hide();
            sellQTYTextbox.Hide();
            searchResultList.Height = 350; 

        }

        private void userInput()
        {
            input = Microsoft.VisualBasic.Interaction.InputBox("How many dollars would you like to start off with?", "Initial amount", "0", -1, -1);
            //saving
            double savedMoney = Convert.ToDouble(input);
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
            stocksPanel.Hide();

            summary_panel.Show();
        }

        private void addToGraph(List<Tuple<String, String>> dataTuple, List<Tuple<String, String, String>> dayTuple)
        {
            chart1.Series.Clear();
            chart1.Series.Add("1");
            chart1.Series["1"].ChartType = SeriesChartType.Line;

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
            String name = this.searchResultList.Text.Trim();
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
            
            String name = this.searchResultList.Text.Trim();  
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
            String name = this.searchResultList.Text.Trim();
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
            String name = this.searchResultList.Text.Trim();
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
            String name = this.searchResultList.Text.Trim();
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
            String name = this.searchResultList.Text.Trim();
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
    }
}
