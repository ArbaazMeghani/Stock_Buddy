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
        public Form1()
        {
            InitializeComponent();
            stocksPanel.Hide();
            purchasePanel.Hide();
            watchlistPanel.Hide();
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

        private void StocksBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            purchasePanel.Hide();
            watchlistPanel.Hide();
            stocksPanel.Show();
        }

        private void purchasedBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Hide();
            watchlistPanel.Hide();
            purchasePanel.Show();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            handleNav_Click((Button)sender);
            stocksPanel.Hide();
            purchasePanel.Hide();
            watchlistPanel.Show();
        }

        private void stocksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
