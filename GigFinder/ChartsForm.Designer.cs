namespace GigFinder
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAplications = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEvents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chartType
            // 
            chartArea10.Name = "ChartArea1";
            this.chartType.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartType.Legends.Add(legend10);
            this.chartType.Location = new System.Drawing.Point(19, 182);
            this.chartType.Name = "chartType";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartType.Series.Add(series10);
            this.chartType.Size = new System.Drawing.Size(374, 316);
            this.chartType.TabIndex = 11;
            this.chartType.Text = "User types";
            // 
            // chartAplications
            // 
            chartArea11.Name = "ChartArea1";
            this.chartAplications.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartAplications.Legends.Add(legend11);
            this.chartAplications.Location = new System.Drawing.Point(412, 182);
            this.chartAplications.Name = "chartAplications";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartAplications.Series.Add(series11);
            this.chartAplications.Size = new System.Drawing.Size(362, 316);
            this.chartAplications.TabIndex = 12;
            this.chartAplications.Text = "User types";
            // 
            // chartEvents
            // 
            chartArea12.Name = "ChartArea1";
            this.chartEvents.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartEvents.Legends.Add(legend12);
            this.chartEvents.Location = new System.Drawing.Point(790, 182);
            this.chartEvents.Name = "chartEvents";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartEvents.Series.Add(series12);
            this.chartEvents.Size = new System.Drawing.Size(378, 316);
            this.chartEvents.TabIndex = 13;
            this.chartEvents.Text = "User types";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 50F);
            this.labelTitle.Location = new System.Drawing.Point(6, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(483, 74);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Resumen de datos";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::GigFinder.Properties.Resources.logo1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1093, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 90);
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.chartEvents);
            this.Controls.Add(this.chartAplications);
            this.Controls.Add(this.chartType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartsForm";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAplications;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvents;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}