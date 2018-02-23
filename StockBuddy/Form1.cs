using StockBuddy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockBuddy
{
    public partial class Form1 : Form
    {
        Button currentClicked = null;
        Button graphTabClicked = null;
        public string input;
        public Form1()
        {
            InitializeComponent();
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

        private void Day_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void Month1_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void Month3_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void Month6_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void Year1_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void Year5_Click(object sender, EventArgs e)
        {
            handleGraphTabs_Click((Button)sender);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            userInput();

        }
    }
}
