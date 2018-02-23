﻿namespace StockBuddy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.navPan = new System.Windows.Forms.Panel();
            this.summaryPane = new System.Windows.Forms.Panel();
            this.net_label = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.watchBtn = new System.Windows.Forms.Button();
            this.purchasedBtn = new System.Windows.Forms.Button();
            this.stocksBtn = new System.Windows.Forms.Button();
            this.infoPane = new System.Windows.Forms.Panel();
            this.stocksPanel = new System.Windows.Forms.Panel();
            this.divYield = new System.Windows.Forms.Label();
            this.peRatio = new System.Windows.Forms.Label();
            this.marketCap = new System.Windows.Forms.Label();
            this.avgVolume = new System.Windows.Forms.Label();
            this.VOLUME = new System.Windows.Forms.Label();
            this.yearLow = new System.Windows.Forms.Label();
            this.yearHigh = new System.Windows.Forms.Label();
            this.LOW = new System.Windows.Forms.Label();
            this.HIGH = new System.Windows.Forms.Label();
            this.OPEN = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Year5 = new System.Windows.Forms.Button();
            this.Year1 = new System.Windows.Forms.Button();
            this.Month6 = new System.Windows.Forms.Button();
            this.Month3 = new System.Windows.Forms.Button();
            this.Month1 = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.removeFromWatchlist = new System.Windows.Forms.Button();
            this.addToWatchlist = new System.Windows.Forms.Button();
            this.sellQTYTextbox = new System.Windows.Forms.TextBox();
            this.sellQTYLabel = new System.Windows.Forms.Label();
            this.purchaseBoxTextbox = new System.Windows.Forms.TextBox();
            this.purchaseQTYLabel = new System.Windows.Forms.Label();
            this.searchResultList = new System.Windows.Forms.ListBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.summary_panel = new System.Windows.Forms.Panel();
            this.net_label2 = new System.Windows.Forms.Label();
            this.titlePane = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.current_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.current_time = new System.Windows.Forms.Label();
            this.navPan.SuspendLayout();
            this.summaryPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.infoPane.SuspendLayout();
            this.stocksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.summary_panel.SuspendLayout();
            this.titlePane.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPan
            // 
            this.navPan.BackColor = System.Drawing.Color.Transparent;
            this.navPan.Controls.Add(this.summaryPane);
            this.navPan.Controls.Add(this.watchBtn);
            this.navPan.Controls.Add(this.purchasedBtn);
            this.navPan.Controls.Add(this.stocksBtn);
            this.navPan.Location = new System.Drawing.Point(-1, 23);
            this.navPan.Margin = new System.Windows.Forms.Padding(2);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(256, 563);
            this.navPan.TabIndex = 0;
            // 
            // summaryPane
            // 
            this.summaryPane.BackColor = System.Drawing.Color.Transparent;
            this.summaryPane.Controls.Add(this.current_date);
            this.summaryPane.Controls.Add(this.net_label);
            this.summaryPane.Controls.Add(this.profilePicture);
            this.summaryPane.Controls.Add(this.current_time);
            this.summaryPane.Controls.Add(this.amountLabel);
            this.summaryPane.Location = new System.Drawing.Point(0, -12);
            this.summaryPane.Margin = new System.Windows.Forms.Padding(2);
            this.summaryPane.Name = "summaryPane";
            this.summaryPane.Size = new System.Drawing.Size(255, 269);
            this.summaryPane.TabIndex = 0;
            // 
            // net_label
            // 
            this.net_label.AutoSize = true;
            this.net_label.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.net_label.Location = new System.Drawing.Point(13, 186);
            this.net_label.Name = "net_label";
            this.net_label.Size = new System.Drawing.Size(46, 25);
            this.net_label.TabIndex = 5;
            this.net_label.Text = "NET";
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.BackgroundImage")));
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(12, 13);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(120, 119);
            this.profilePicture.TabIndex = 4;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.amountLabel.Location = new System.Drawing.Point(12, 146);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(90, 27);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$20,000";
            // 
            // watchBtn
            // 
            this.watchBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchBtn.FlatAppearance.BorderSize = 0;
            this.watchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.watchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.watchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.watchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.watchBtn.Location = new System.Drawing.Point(2, 465);
            this.watchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(250, 91);
            this.watchBtn.TabIndex = 3;
            this.watchBtn.Text = "Watch List";
            this.watchBtn.UseVisualStyleBackColor = false;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // purchasedBtn
            // 
            this.purchasedBtn.BackColor = System.Drawing.Color.Transparent;
            this.purchasedBtn.FlatAppearance.BorderSize = 0;
            this.purchasedBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.purchasedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.purchasedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.purchasedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasedBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.purchasedBtn.Location = new System.Drawing.Point(2, 369);
            this.purchasedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.purchasedBtn.Name = "purchasedBtn";
            this.purchasedBtn.Size = new System.Drawing.Size(250, 91);
            this.purchasedBtn.TabIndex = 2;
            this.purchasedBtn.Text = "Purchased";
            this.purchasedBtn.UseVisualStyleBackColor = false;
            this.purchasedBtn.Click += new System.EventHandler(this.purchasedBtn_Click);
            // 
            // stocksBtn
            // 
            this.stocksBtn.BackColor = System.Drawing.Color.Transparent;
            this.stocksBtn.FlatAppearance.BorderSize = 0;
            this.stocksBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.stocksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stocksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocksBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stocksBtn.Location = new System.Drawing.Point(0, 273);
            this.stocksBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stocksBtn.Name = "stocksBtn";
            this.stocksBtn.Size = new System.Drawing.Size(252, 91);
            this.stocksBtn.TabIndex = 1;
            this.stocksBtn.Text = "Stocks";
            this.stocksBtn.UseVisualStyleBackColor = false;
            this.stocksBtn.Click += new System.EventHandler(this.StocksBtn_Click);
            // 
            // infoPane
            // 
            this.infoPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoPane.BackColor = System.Drawing.Color.Transparent;
            this.infoPane.Controls.Add(this.stocksPanel);
            this.infoPane.Controls.Add(this.summary_panel);
            this.infoPane.Location = new System.Drawing.Point(260, 36);
            this.infoPane.Margin = new System.Windows.Forms.Padding(2);
            this.infoPane.Name = "infoPane";
            this.infoPane.Size = new System.Drawing.Size(692, 540);
            this.infoPane.TabIndex = 1;
            // 
            // stocksPanel
            // 
            this.stocksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stocksPanel.Controls.Add(this.divYield);
            this.stocksPanel.Controls.Add(this.peRatio);
            this.stocksPanel.Controls.Add(this.marketCap);
            this.stocksPanel.Controls.Add(this.avgVolume);
            this.stocksPanel.Controls.Add(this.VOLUME);
            this.stocksPanel.Controls.Add(this.yearLow);
            this.stocksPanel.Controls.Add(this.yearHigh);
            this.stocksPanel.Controls.Add(this.LOW);
            this.stocksPanel.Controls.Add(this.HIGH);
            this.stocksPanel.Controls.Add(this.OPEN);
            this.stocksPanel.Controls.Add(this.chart1);
            this.stocksPanel.Controls.Add(this.label12);
            this.stocksPanel.Controls.Add(this.label11);
            this.stocksPanel.Controls.Add(this.label10);
            this.stocksPanel.Controls.Add(this.label9);
            this.stocksPanel.Controls.Add(this.label8);
            this.stocksPanel.Controls.Add(this.label7);
            this.stocksPanel.Controls.Add(this.label6);
            this.stocksPanel.Controls.Add(this.label5);
            this.stocksPanel.Controls.Add(this.label4);
            this.stocksPanel.Controls.Add(this.label3);
            this.stocksPanel.Controls.Add(this.label2);
            this.stocksPanel.Controls.Add(this.label1);
            this.stocksPanel.Controls.Add(this.Year5);
            this.stocksPanel.Controls.Add(this.Year1);
            this.stocksPanel.Controls.Add(this.Month6);
            this.stocksPanel.Controls.Add(this.Month3);
            this.stocksPanel.Controls.Add(this.Month1);
            this.stocksPanel.Controls.Add(this.Day);
            this.stocksPanel.Controls.Add(this.searchPanel);
            this.stocksPanel.Location = new System.Drawing.Point(0, 0);
            this.stocksPanel.Margin = new System.Windows.Forms.Padding(2);
            this.stocksPanel.Name = "stocksPanel";
            this.stocksPanel.Size = new System.Drawing.Size(692, 537);
            this.stocksPanel.TabIndex = 2;
            this.stocksPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.stocksPanel_Paint);
            // 
            // divYield
            // 
            this.divYield.AutoSize = true;
            this.divYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divYield.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divYield.Location = new System.Drawing.Point(580, 448);
            this.divYield.Name = "divYield";
            this.divYield.Size = new System.Drawing.Size(48, 25);
            this.divYield.TabIndex = 30;
            this.divYield.Text = "300";
            // 
            // peRatio
            // 
            this.peRatio.AutoSize = true;
            this.peRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peRatio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.peRatio.Location = new System.Drawing.Point(580, 421);
            this.peRatio.Name = "peRatio";
            this.peRatio.Size = new System.Drawing.Size(48, 25);
            this.peRatio.TabIndex = 29;
            this.peRatio.Text = "300";
            // 
            // marketCap
            // 
            this.marketCap.AutoSize = true;
            this.marketCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketCap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marketCap.Location = new System.Drawing.Point(580, 392);
            this.marketCap.Name = "marketCap";
            this.marketCap.Size = new System.Drawing.Size(48, 25);
            this.marketCap.TabIndex = 28;
            this.marketCap.Text = "300";
            // 
            // avgVolume
            // 
            this.avgVolume.AutoSize = true;
            this.avgVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgVolume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.avgVolume.Location = new System.Drawing.Point(580, 363);
            this.avgVolume.Name = "avgVolume";
            this.avgVolume.Size = new System.Drawing.Size(48, 25);
            this.avgVolume.TabIndex = 27;
            this.avgVolume.Text = "300";
            // 
            // VOLUME
            // 
            this.VOLUME.AutoSize = true;
            this.VOLUME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOLUME.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VOLUME.Location = new System.Drawing.Point(580, 332);
            this.VOLUME.Name = "VOLUME";
            this.VOLUME.Size = new System.Drawing.Size(48, 25);
            this.VOLUME.TabIndex = 26;
            this.VOLUME.Text = "300";
            // 
            // yearLow
            // 
            this.yearLow.AutoSize = true;
            this.yearLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearLow.Location = new System.Drawing.Point(330, 450);
            this.yearLow.Name = "yearLow";
            this.yearLow.Size = new System.Drawing.Size(48, 25);
            this.yearLow.TabIndex = 25;
            this.yearLow.Text = "300";
            // 
            // yearHigh
            // 
            this.yearHigh.AutoSize = true;
            this.yearHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearHigh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearHigh.Location = new System.Drawing.Point(330, 422);
            this.yearHigh.Name = "yearHigh";
            this.yearHigh.Size = new System.Drawing.Size(48, 25);
            this.yearHigh.TabIndex = 24;
            this.yearHigh.Text = "300";
            // 
            // LOW
            // 
            this.LOW.AutoSize = true;
            this.LOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LOW.Location = new System.Drawing.Point(330, 392);
            this.LOW.Name = "LOW";
            this.LOW.Size = new System.Drawing.Size(48, 25);
            this.LOW.TabIndex = 23;
            this.LOW.Text = "300";
            // 
            // HIGH
            // 
            this.HIGH.AutoSize = true;
            this.HIGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIGH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HIGH.Location = new System.Drawing.Point(330, 363);
            this.HIGH.Name = "HIGH";
            this.HIGH.Size = new System.Drawing.Size(48, 25);
            this.HIGH.TabIndex = 22;
            this.HIGH.Text = "300";
            // 
            // OPEN
            // 
            this.OPEN.AutoSize = true;
            this.OPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPEN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OPEN.Location = new System.Drawing.Point(330, 332);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(48, 25);
            this.OPEN.TabIndex = 21;
            this.OPEN.Text = "300";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightSlateGray;
            chartArea11.BackColor = System.Drawing.Color.Gray;
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            this.chart1.Location = new System.Drawing.Point(206, 27);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(447, 244);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(414, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "CURRENT PRICE:    9999.99";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Beige;
            this.label11.Location = new System.Drawing.Point(209, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "2/14/2018 10:32 PM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(446, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "DIV/YIELD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(446, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "P/E RATIO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(446, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "MKT CAP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(446, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "AVG VOL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(446, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "VOLUME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(203, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "52 WK LOW:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(203, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "52 WK HIGH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(202, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOW:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(203, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "HIGH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(203, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "OPEN:";
            // 
            // Year5
            // 
            this.Year5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year5.ForeColor = System.Drawing.Color.DarkOrange;
            this.Year5.Location = new System.Drawing.Point(585, 7);
            this.Year5.Margin = new System.Windows.Forms.Padding(2);
            this.Year5.Name = "Year5";
            this.Year5.Size = new System.Drawing.Size(68, 21);
            this.Year5.TabIndex = 7;
            this.Year5.Text = "5 Years";
            this.Year5.UseVisualStyleBackColor = true;
            this.Year5.Click += new System.EventHandler(this.Year5_Click);
            // 
            // Year1
            // 
            this.Year1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Year1.Location = new System.Drawing.Point(513, 7);
            this.Year1.Margin = new System.Windows.Forms.Padding(2);
            this.Year1.Name = "Year1";
            this.Year1.Size = new System.Drawing.Size(68, 21);
            this.Year1.TabIndex = 6;
            this.Year1.Text = "1 Year";
            this.Year1.UseVisualStyleBackColor = true;
            this.Year1.Click += new System.EventHandler(this.Year1_Click);
            // 
            // Month6
            // 
            this.Month6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month6.ForeColor = System.Drawing.Color.DarkOrange;
            this.Month6.Location = new System.Drawing.Point(441, 7);
            this.Month6.Margin = new System.Windows.Forms.Padding(2);
            this.Month6.Name = "Month6";
            this.Month6.Size = new System.Drawing.Size(68, 21);
            this.Month6.TabIndex = 5;
            this.Month6.Text = "6 Months";
            this.Month6.UseVisualStyleBackColor = true;
            this.Month6.Click += new System.EventHandler(this.Month6_Click);
            // 
            // Month3
            // 
            this.Month3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month3.ForeColor = System.Drawing.Color.DarkOrange;
            this.Month3.Location = new System.Drawing.Point(369, 7);
            this.Month3.Margin = new System.Windows.Forms.Padding(2);
            this.Month3.Name = "Month3";
            this.Month3.Size = new System.Drawing.Size(68, 21);
            this.Month3.TabIndex = 4;
            this.Month3.Text = "3 Months";
            this.Month3.UseVisualStyleBackColor = true;
            this.Month3.Click += new System.EventHandler(this.Month3_Click);
            // 
            // Month1
            // 
            this.Month1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Month1.Location = new System.Drawing.Point(297, 7);
            this.Month1.Margin = new System.Windows.Forms.Padding(2);
            this.Month1.Name = "Month1";
            this.Month1.Size = new System.Drawing.Size(68, 21);
            this.Month1.TabIndex = 3;
            this.Month1.Text = "1 Month";
            this.Month1.UseVisualStyleBackColor = true;
            this.Month1.Click += new System.EventHandler(this.Month1_Click);
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.Color.Transparent;
            this.Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Day.ForeColor = System.Drawing.Color.DarkOrange;
            this.Day.Location = new System.Drawing.Point(225, 7);
            this.Day.Margin = new System.Windows.Forms.Padding(2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(68, 21);
            this.Day.TabIndex = 2;
            this.Day.Text = "1 Day";
            this.Day.UseVisualStyleBackColor = false;
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.removeFromWatchlist);
            this.searchPanel.Controls.Add(this.addToWatchlist);
            this.searchPanel.Controls.Add(this.sellQTYTextbox);
            this.searchPanel.Controls.Add(this.sellQTYLabel);
            this.searchPanel.Controls.Add(this.purchaseBoxTextbox);
            this.searchPanel.Controls.Add(this.purchaseQTYLabel);
            this.searchPanel.Controls.Add(this.searchResultList);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Location = new System.Drawing.Point(2, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(153, 540);
            this.searchPanel.TabIndex = 0;
            // 
            // removeFromWatchlist
            // 
            this.removeFromWatchlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeFromWatchlist.FlatAppearance.BorderSize = 0;
            this.removeFromWatchlist.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.removeFromWatchlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.removeFromWatchlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.removeFromWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFromWatchlist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromWatchlist.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeFromWatchlist.Location = new System.Drawing.Point(3, 332);
            this.removeFromWatchlist.Margin = new System.Windows.Forms.Padding(2);
            this.removeFromWatchlist.Name = "removeFromWatchlist";
            this.removeFromWatchlist.Size = new System.Drawing.Size(147, 62);
            this.removeFromWatchlist.TabIndex = 25;
            this.removeFromWatchlist.Text = "REMOVE FROM WATCHLIST";
            this.removeFromWatchlist.UseVisualStyleBackColor = false;
            // 
            // addToWatchlist
            // 
            this.addToWatchlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToWatchlist.FlatAppearance.BorderSize = 0;
            this.addToWatchlist.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.addToWatchlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addToWatchlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addToWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToWatchlist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToWatchlist.ForeColor = System.Drawing.Color.Gainsboro;
            this.addToWatchlist.Location = new System.Drawing.Point(3, 403);
            this.addToWatchlist.Margin = new System.Windows.Forms.Padding(2);
            this.addToWatchlist.Name = "addToWatchlist";
            this.addToWatchlist.Size = new System.Drawing.Size(147, 62);
            this.addToWatchlist.TabIndex = 24;
            this.addToWatchlist.Text = "ADD TO WATCHLIST";
            this.addToWatchlist.UseVisualStyleBackColor = false;
            // 
            // sellQTYTextbox
            // 
            this.sellQTYTextbox.Location = new System.Drawing.Point(77, 471);
            this.sellQTYTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.sellQTYTextbox.Name = "sellQTYTextbox";
            this.sellQTYTextbox.Size = new System.Drawing.Size(79, 20);
            this.sellQTYTextbox.TabIndex = 23;
            // 
            // sellQTYLabel
            // 
            this.sellQTYLabel.AutoSize = true;
            this.sellQTYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellQTYLabel.ForeColor = System.Drawing.Color.Red;
            this.sellQTYLabel.Location = new System.Drawing.Point(0, 476);
            this.sellQTYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellQTYLabel.Name = "sellQTYLabel";
            this.sellQTYLabel.Size = new System.Drawing.Size(79, 17);
            this.sellQTYLabel.TabIndex = 22;
            this.sellQTYLabel.Text = "SELL QTY:";
            // 
            // purchaseBoxTextbox
            // 
            this.purchaseBoxTextbox.Location = new System.Drawing.Point(77, 495);
            this.purchaseBoxTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseBoxTextbox.Name = "purchaseBoxTextbox";
            this.purchaseBoxTextbox.Size = new System.Drawing.Size(79, 20);
            this.purchaseBoxTextbox.TabIndex = 21;
            // 
            // purchaseQTYLabel
            // 
            this.purchaseQTYLabel.AutoSize = true;
            this.purchaseQTYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseQTYLabel.ForeColor = System.Drawing.Color.Lime;
            this.purchaseQTYLabel.Location = new System.Drawing.Point(-1, 498);
            this.purchaseQTYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchaseQTYLabel.Name = "purchaseQTYLabel";
            this.purchaseQTYLabel.Size = new System.Drawing.Size(74, 17);
            this.purchaseQTYLabel.TabIndex = 20;
            this.purchaseQTYLabel.Text = "PUR QTY:";
            // 
            // searchResultList
            // 
            this.searchResultList.BackColor = System.Drawing.Color.LightSlateGray;
            this.searchResultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultList.FormattingEnabled = true;
            this.searchResultList.ItemHeight = 20;
            this.searchResultList.Location = new System.Drawing.Point(2, 42);
            this.searchResultList.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.Size = new System.Drawing.Size(150, 264);
            this.searchResultList.TabIndex = 1;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Black;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchText.Location = new System.Drawing.Point(2, 9);
            this.searchText.Margin = new System.Windows.Forms.Padding(2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(149, 29);
            this.searchText.TabIndex = 0;
            this.searchText.Text = "Search";
            // 
            // summary_panel
            // 
            this.summary_panel.Controls.Add(this.reset_btn);
            this.summary_panel.Controls.Add(this.net_label2);
            this.summary_panel.Location = new System.Drawing.Point(0, 0);
            this.summary_panel.Name = "summary_panel";
            this.summary_panel.Size = new System.Drawing.Size(692, 543);
            this.summary_panel.TabIndex = 32;
            // 
            // net_label2
            // 
            this.net_label2.AutoSize = true;
            this.net_label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.net_label2.Location = new System.Drawing.Point(5, 40);
            this.net_label2.Name = "net_label2";
            this.net_label2.Size = new System.Drawing.Size(51, 24);
            this.net_label2.TabIndex = 0;
            this.net_label2.Text = "NET";
            // 
            // titlePane
            // 
            this.titlePane.BackColor = System.Drawing.Color.Transparent;
            this.titlePane.Controls.Add(this.minimizeBtn);
            this.titlePane.Controls.Add(this.exitButton);
            this.titlePane.Location = new System.Drawing.Point(259, 2);
            this.titlePane.Margin = new System.Windows.Forms.Padding(2);
            this.titlePane.Name = "titlePane";
            this.titlePane.Size = new System.Drawing.Size(703, 33);
            this.titlePane.TabIndex = 2;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimizeBtn.Location = new System.Drawing.Point(630, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(33, 25);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Location = new System.Drawing.Point(667, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 25);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Red;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Snow;
            this.reset_btn.Location = new System.Drawing.Point(617, 0);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 28);
            this.reset_btn.TabIndex = 1;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // current_date
            // 
            this.current_date.AutoSize = true;
            this.current_date.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.Color.Gainsboro;
            this.current_date.Location = new System.Drawing.Point(137, 12);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(108, 23);
            this.current_date.TabIndex = 6;
            this.current_date.Text = "88/88/8888";
            this.current_date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // current_time
            // 
            this.current_time.AutoSize = true;
            this.current_time.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_time.ForeColor = System.Drawing.Color.Gainsboro;
            this.current_time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.current_time.Location = new System.Drawing.Point(150, 104);
            this.current_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.current_time.Name = "current_time";
            this.current_time.Size = new System.Drawing.Size(104, 28);
            this.current_time.TabIndex = 3;
            this.current_time.Text = "12:43:99";
            this.current_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.titlePane);
            this.Controls.Add(this.infoPane);
            this.Controls.Add(this.navPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navPan.ResumeLayout(false);
            this.summaryPane.ResumeLayout(false);
            this.summaryPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.infoPane.ResumeLayout(false);
            this.stocksPanel.ResumeLayout(false);
            this.stocksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.summary_panel.ResumeLayout(false);
            this.summary_panel.PerformLayout();
            this.titlePane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPan;
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.Button purchasedBtn;
        private System.Windows.Forms.Button stocksBtn;
        private System.Windows.Forms.Panel summaryPane;
        private System.Windows.Forms.Panel infoPane;
        private System.Windows.Forms.Panel titlePane;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel stocksPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ListBox searchResultList;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Year5;
        private System.Windows.Forms.Button Year1;
        private System.Windows.Forms.Button Month6;
        private System.Windows.Forms.Button Month3;
        private System.Windows.Forms.Button Month1;
        private System.Windows.Forms.Button Day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addToWatchlist;
        private System.Windows.Forms.TextBox sellQTYTextbox;
        private System.Windows.Forms.Label sellQTYLabel;
        private System.Windows.Forms.TextBox purchaseBoxTextbox;
        private System.Windows.Forms.Label purchaseQTYLabel;
        private System.Windows.Forms.Label divYield;
        private System.Windows.Forms.Label peRatio;
        private System.Windows.Forms.Label marketCap;
        private System.Windows.Forms.Label avgVolume;
        private System.Windows.Forms.Label VOLUME;
        private System.Windows.Forms.Label yearLow;
        private System.Windows.Forms.Label yearHigh;
        private System.Windows.Forms.Label LOW;
        private System.Windows.Forms.Label HIGH;
        private System.Windows.Forms.Label OPEN;
        private System.Windows.Forms.Panel summary_panel;
        private System.Windows.Forms.Label net_label2;
        private System.Windows.Forms.Label net_label;
        private System.Windows.Forms.Button removeFromWatchlist;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label current_date;
        private System.Windows.Forms.Label current_time;
        private System.Windows.Forms.Timer timer1;
    }
}

