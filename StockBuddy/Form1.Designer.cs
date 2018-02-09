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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.titlePane = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stocksPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchResultList = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.navPan.SuspendLayout();
            this.summaryPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.infoPane.SuspendLayout();
            this.titlePane.SuspendLayout();
            this.stocksPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // navPan
            // 
            this.navPan.Controls.Add(this.summaryPane);
            this.navPan.Controls.Add(this.watchBtn);
            this.navPan.Controls.Add(this.purchasedBtn);
            this.navPan.Controls.Add(this.stocksBtn);
            this.navPan.Location = new System.Drawing.Point(0, 0);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(340, 720);
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
            this.summaryPane.Name = "summaryPane";
            this.summaryPane.Size = new System.Drawing.Size(340, 316);
            this.summaryPane.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.BackgroundImage")));
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(26, 12);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(150, 150);
            this.profilePicture.TabIndex = 4;
            this.profilePicture.TabStop = false;
            // 
            // refreshTimerLabel
            // 
            this.refreshTimerLabel.AutoSize = true;
            this.refreshTimerLabel.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTimerLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.refreshTimerLabel.Location = new System.Drawing.Point(210, 106);
            this.refreshTimerLabel.Name = "refreshTimerLabel";
            this.refreshTimerLabel.Size = new System.Drawing.Size(91, 35);
            this.refreshTimerLabel.TabIndex = 3;
            this.refreshTimerLabel.Text = "12:43";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.amountLabel.Location = new System.Drawing.Point(196, 44);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(119, 33);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$20,000";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.summaryLabel.Location = new System.Drawing.Point(97, 174);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(152, 35);
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
            this.watchBtn.Location = new System.Drawing.Point(3, 572);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(334, 112);
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
            this.purchasedBtn.Location = new System.Drawing.Point(3, 454);
            this.purchasedBtn.Name = "purchasedBtn";
            this.purchasedBtn.Size = new System.Drawing.Size(334, 112);
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
            this.stocksBtn.Location = new System.Drawing.Point(3, 336);
            this.stocksBtn.Name = "stocksBtn";
            this.stocksBtn.Size = new System.Drawing.Size(334, 112);
            this.stocksBtn.TabIndex = 1;
            this.stocksBtn.Text = "Stocks";
            this.stocksBtn.UseVisualStyleBackColor = false;
            this.stocksBtn.Click += new System.EventHandler(this.StocksBtn_Click);
            // 
            // infoPane
            // 
            this.infoPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoPane.Controls.Add(this.stocksPanel);
            this.infoPane.Location = new System.Drawing.Point(346, 44);
            this.infoPane.Name = "infoPane";
            this.infoPane.Size = new System.Drawing.Size(922, 664);
            this.infoPane.TabIndex = 1;
            // 
            // titlePane
            // 
            this.titlePane.Controls.Add(this.minimizeBtn);
            this.titlePane.Controls.Add(this.exitButton);
            this.titlePane.Location = new System.Drawing.Point(346, 0);
            this.titlePane.Name = "titlePane";
            this.titlePane.Size = new System.Drawing.Size(922, 38);
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
            this.minimizeBtn.Location = new System.Drawing.Point(827, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(43, 38);
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
            this.exitButton.Location = new System.Drawing.Point(876, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 38);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stocksPanel
            // 
            this.stocksPanel.Controls.Add(this.chart2);
            this.stocksPanel.Controls.Add(this.chart1);
            this.stocksPanel.Controls.Add(this.searchPanel);
            this.stocksPanel.Location = new System.Drawing.Point(0, 0);
            this.stocksPanel.Name = "stocksPanel";
            this.stocksPanel.Size = new System.Drawing.Size(922, 661);
            this.stocksPanel.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchResultList);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Location = new System.Drawing.Point(3, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(204, 664);
            this.searchPanel.TabIndex = 0;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Gray;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(3, 11);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(198, 34);
            this.searchText.TabIndex = 0;
            this.searchText.Text = "Search";
            // 
            // searchResultList
            // 
            this.searchResultList.BackColor = System.Drawing.Color.Gray;
            this.searchResultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultList.FormattingEnabled = true;
            this.searchResultList.ItemHeight = 25;
            this.searchResultList.Location = new System.Drawing.Point(3, 62);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.Size = new System.Drawing.Size(198, 579);
            this.searchResultList.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            chartArea2.BackColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(274, 11);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(596, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(274, 340);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(596, 300);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.titlePane);
            this.Controls.Add(this.infoPane);
            this.Controls.Add(this.navPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.navPan.ResumeLayout(false);
            this.summaryPane.ResumeLayout(false);
            this.summaryPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.infoPane.ResumeLayout(false);
            this.titlePane.ResumeLayout(false);
            this.stocksPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
    }
}

