namespace StockBuddy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.navPan = new System.Windows.Forms.Panel();
            this.summaryPane = new System.Windows.Forms.Panel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.refreshTimerLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.watchBtn = new System.Windows.Forms.Button();
            this.purchasedBtn = new System.Windows.Forms.Button();
            this.stocksBtn = new System.Windows.Forms.Button();
            this.infoPane = new System.Windows.Forms.Panel();
            this.stocksPanel = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchResultList = new System.Windows.Forms.ListBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.titlePane = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.purchasePanel = new System.Windows.Forms.Panel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.navPan.SuspendLayout();
            this.summaryPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.infoPane.SuspendLayout();
            this.stocksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.titlePane.SuspendLayout();
            this.purchasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPan
            // 
            this.navPan.Controls.Add(this.summaryPane);
            this.navPan.Controls.Add(this.watchBtn);
            this.navPan.Controls.Add(this.purchasedBtn);
            this.navPan.Controls.Add(this.stocksBtn);
            this.navPan.Location = new System.Drawing.Point(0, 0);
            this.navPan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(382, 900);
            this.navPan.TabIndex = 0;
            // 
            // summaryPane
            // 
            this.summaryPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.summaryPane.Controls.Add(this.profilePicture);
            this.summaryPane.Controls.Add(this.refreshTimerLabel);
            this.summaryPane.Controls.Add(this.amountLabel);
            this.summaryPane.Controls.Add(this.summaryLabel);
            this.summaryPane.Location = new System.Drawing.Point(0, 0);
            this.summaryPane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.summaryPane.Name = "summaryPane";
            this.summaryPane.Size = new System.Drawing.Size(382, 395);
            this.summaryPane.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.BackgroundImage")));
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(29, 15);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(169, 188);
            this.profilePicture.TabIndex = 4;
            this.profilePicture.TabStop = false;
            // 
            // refreshTimerLabel
            // 
            this.refreshTimerLabel.AutoSize = true;
            this.refreshTimerLabel.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTimerLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.refreshTimerLabel.Location = new System.Drawing.Point(236, 132);
            this.refreshTimerLabel.Name = "refreshTimerLabel";
            this.refreshTimerLabel.Size = new System.Drawing.Size(108, 42);
            this.refreshTimerLabel.TabIndex = 3;
            this.refreshTimerLabel.Text = "12:43";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.amountLabel.Location = new System.Drawing.Point(220, 55);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(134, 39);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$20,000";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.summaryLabel.Location = new System.Drawing.Point(109, 218);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(182, 42);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "Summary";
            // 
            // watchBtn
            // 
            this.watchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.watchBtn.FlatAppearance.BorderSize = 0;
            this.watchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.watchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.watchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.watchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.watchBtn.Location = new System.Drawing.Point(3, 715);
            this.watchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(376, 140);
            this.watchBtn.TabIndex = 3;
            this.watchBtn.Text = "Watch List";
            this.watchBtn.UseVisualStyleBackColor = false;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // purchasedBtn
            // 
            this.purchasedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchasedBtn.FlatAppearance.BorderSize = 0;
            this.purchasedBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.purchasedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.purchasedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.purchasedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasedBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.purchasedBtn.Location = new System.Drawing.Point(3, 568);
            this.purchasedBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchasedBtn.Name = "purchasedBtn";
            this.purchasedBtn.Size = new System.Drawing.Size(376, 140);
            this.purchasedBtn.TabIndex = 2;
            this.purchasedBtn.Text = "Purchased";
            this.purchasedBtn.UseVisualStyleBackColor = false;
            this.purchasedBtn.Click += new System.EventHandler(this.purchasedBtn_Click);
            // 
            // stocksBtn
            // 
            this.stocksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stocksBtn.FlatAppearance.BorderSize = 0;
            this.stocksBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.stocksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stocksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocksBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stocksBtn.Location = new System.Drawing.Point(3, 420);
            this.stocksBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stocksBtn.Name = "stocksBtn";
            this.stocksBtn.Size = new System.Drawing.Size(376, 140);
            this.stocksBtn.TabIndex = 1;
            this.stocksBtn.Text = "Stocks";
            this.stocksBtn.UseVisualStyleBackColor = false;
            this.stocksBtn.Click += new System.EventHandler(this.StocksBtn_Click);
            // 
            // infoPane
            // 
            this.infoPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoPane.Controls.Add(this.purchasePanel);
            this.infoPane.Controls.Add(this.stocksPanel);
            this.infoPane.Location = new System.Drawing.Point(389, 55);
            this.infoPane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPane.Name = "infoPane";
            this.infoPane.Size = new System.Drawing.Size(1037, 830);
            this.infoPane.TabIndex = 1;
            // 
            // stocksPanel
            // 
            this.stocksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stocksPanel.Controls.Add(this.chart2);
            this.stocksPanel.Controls.Add(this.chart1);
            this.stocksPanel.Controls.Add(this.searchPanel);
            this.stocksPanel.Location = new System.Drawing.Point(0, 0);
            this.stocksPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stocksPanel.Name = "stocksPanel";
            this.stocksPanel.Size = new System.Drawing.Size(1037, 826);
            this.stocksPanel.TabIndex = 2;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Gray;
            chartArea15.BackColor = System.Drawing.Color.Gray;
            chartArea15.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea15);
            this.chart2.Location = new System.Drawing.Point(308, 425);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Name = "Series1";
            this.chart2.Series.Add(series15);
            this.chart2.Size = new System.Drawing.Size(670, 375);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            chartArea16.BackColor = System.Drawing.Color.Gray;
            chartArea16.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea16);
            this.chart1.Location = new System.Drawing.Point(308, 14);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Name = "Series1";
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(670, 375);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchResultList);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Location = new System.Drawing.Point(3, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(230, 830);
            this.searchPanel.TabIndex = 0;
            // 
            // searchResultList
            // 
            this.searchResultList.BackColor = System.Drawing.Color.Gray;
            this.searchResultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultList.FormattingEnabled = true;
            this.searchResultList.ItemHeight = 29;
            this.searchResultList.Location = new System.Drawing.Point(3, 78);
            this.searchResultList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.Size = new System.Drawing.Size(222, 700);
            this.searchResultList.TabIndex = 1;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Gray;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(3, 14);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(222, 39);
            this.searchText.TabIndex = 0;
            this.searchText.Text = "Search";
            // 
            // titlePane
            // 
            this.titlePane.Controls.Add(this.minimizeBtn);
            this.titlePane.Controls.Add(this.exitButton);
            this.titlePane.Location = new System.Drawing.Point(389, 0);
            this.titlePane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlePane.Name = "titlePane";
            this.titlePane.Size = new System.Drawing.Size(1037, 48);
            this.titlePane.TabIndex = 2;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimizeBtn.Location = new System.Drawing.Point(930, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(48, 48);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Location = new System.Drawing.Point(986, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(48, 48);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // purchasePanel
            // 
            this.purchasePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.purchasePanel.Controls.Add(this.chart3);
            this.purchasePanel.Controls.Add(this.chart4);
            this.purchasePanel.Controls.Add(this.panel2);
            this.purchasePanel.Location = new System.Drawing.Point(0, 0);
            this.purchasePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchasePanel.Name = "purchasePanel";
            this.purchasePanel.Size = new System.Drawing.Size(1037, 826);
            this.purchasePanel.TabIndex = 2;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Gray;
            chartArea13.BackColor = System.Drawing.Color.Gray;
            chartArea13.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea13);
            this.chart3.Location = new System.Drawing.Point(308, 425);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart3.Name = "chart3";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Name = "Series1";
            this.chart3.Series.Add(series13);
            this.chart3.Size = new System.Drawing.Size(670, 375);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Gray;
            chartArea14.BackColor = System.Drawing.Color.Gray;
            chartArea14.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea14);
            this.chart4.Location = new System.Drawing.Point(308, 14);
            this.chart4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart4.Name = "chart4";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Name = "Series1";
            this.chart4.Series.Add(series14);
            this.chart4.Size = new System.Drawing.Size(670, 375);
            this.chart4.TabIndex = 1;
            this.chart4.Text = "chart4";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 830);
            this.panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(3, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 700);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.titlePane);
            this.Controls.Add(this.infoPane);
            this.Controls.Add(this.navPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navPan.ResumeLayout(false);
            this.summaryPane.ResumeLayout(false);
            this.summaryPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.infoPane.ResumeLayout(false);
            this.stocksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.titlePane.ResumeLayout(false);
            this.purchasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label refreshTimerLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel stocksPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ListBox searchResultList;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel purchasePanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

