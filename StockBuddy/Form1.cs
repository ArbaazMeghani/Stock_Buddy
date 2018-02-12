using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockBuddy.Properties;

namespace StockBuddy
{
    public partial class Form1 : Form
    {
        Button currentClicked = null;
        public string input;
        public Form1()
        {
            InitializeComponent();
            stocksPanel.Hide();
            purchasePanel.Hide();
            amountLabel.Text = "$" + Convert.ToString(Settings.Default["Money"]);
            //Settings.Default["FirstTime"] = true;
            if(Convert.ToBoolean(Settings.Default["FirstTime"]))
            {
                userInput();
                Settings.Default["FirstTime"] = false;
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
                currentClicked.BackColor = Color.FromArgb(64, 64, 64);

            currentClicked = clicked;
            currentClicked.BackColor = Color.Orange;
            
        }

        private void StocksBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Show();
        }

        private void purchasedBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Hide();
            purchasePanel.Show();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Hide();
            purchasePanel.Hide();
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            userInput();
        }
    }
}
