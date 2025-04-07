namespace GigFinder
{
    partial class ResumeDataForm
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
            this.customPanelMenu = new GigFinder.Controls.CustomPanel();
            this.customPanelCalendar = new GigFinder.Controls.CustomPanel();
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.customPanelMap = new GigFinder.Controls.CustomPanel();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.labelMap = new System.Windows.Forms.Label();
            this.customPanelChart = new GigFinder.Controls.CustomPanel();
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            this.labelChart = new System.Windows.Forms.Label();
            this.customPanelMenu.SuspendLayout();
            this.customPanelCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.customPanelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.customPanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanelMenu
            // 
            this.customPanelMenu.BackColor = System.Drawing.Color.White;
            this.customPanelMenu.BorderRadius = 8;
            this.customPanelMenu.Controls.Add(this.customPanelCalendar);
            this.customPanelMenu.Controls.Add(this.customPanelMap);
            this.customPanelMenu.Controls.Add(this.customPanelChart);
            this.customPanelMenu.Location = new System.Drawing.Point(212, 120);
            this.customPanelMenu.Name = "customPanelMenu";
            this.customPanelMenu.Size = new System.Drawing.Size(721, 400);
            this.customPanelMenu.TabIndex = 2;
            // 
            // customPanelCalendar
            // 
            this.customPanelCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelCalendar.BorderRadius = 8;
            this.customPanelCalendar.Controls.Add(this.pictureBoxCalendar);
            this.customPanelCalendar.Controls.Add(this.labelCalendar);
            this.customPanelCalendar.Location = new System.Drawing.Point(25, 102);
            this.customPanelCalendar.Name = "customPanelCalendar";
            this.customPanelCalendar.Size = new System.Drawing.Size(200, 200);
            this.customPanelCalendar.TabIndex = 3;
            this.customPanelCalendar.Click += new System.EventHandler(this.customPanelCalendar_Click);
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCalendar.BackgroundImage = global::GigFinder.Properties.Resources.calendario;
            this.pictureBoxCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCalendar.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxCalendar.TabIndex = 3;
            this.pictureBoxCalendar.TabStop = false;
            this.pictureBoxCalendar.Click += new System.EventHandler(this.pictureBoxCalendar_Click);
            // 
            // labelCalendar
            // 
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendar.ForeColor = System.Drawing.Color.White;
            this.labelCalendar.Location = new System.Drawing.Point(27, 146);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(139, 36);
            this.labelCalendar.TabIndex = 0;
            this.labelCalendar.Text = "Calendario";
            this.labelCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCalendar.Click += new System.EventHandler(this.labelCalendar_Click);
            // 
            // customPanelMap
            // 
            this.customPanelMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelMap.BorderRadius = 8;
            this.customPanelMap.Controls.Add(this.pictureBoxMap);
            this.customPanelMap.Controls.Add(this.labelMap);
            this.customPanelMap.Location = new System.Drawing.Point(266, 102);
            this.customPanelMap.Name = "customPanelMap";
            this.customPanelMap.Size = new System.Drawing.Size(200, 200);
            this.customPanelMap.TabIndex = 3;
            this.customPanelMap.Click += new System.EventHandler(this.customPanelMap_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.BackgroundImage = global::GigFinder.Properties.Resources.mapa;
            this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMap.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxMap.TabIndex = 4;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.ForeColor = System.Drawing.Color.White;
            this.labelMap.Location = new System.Drawing.Point(60, 146);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(80, 36);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Mapa";
            this.labelMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMap.Click += new System.EventHandler(this.labelMap_Click);
            // 
            // customPanelChart
            // 
            this.customPanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelChart.BorderRadius = 8;
            this.customPanelChart.Controls.Add(this.pictureBoxChart);
            this.customPanelChart.Controls.Add(this.labelChart);
            this.customPanelChart.Location = new System.Drawing.Point(501, 102);
            this.customPanelChart.Name = "customPanelChart";
            this.customPanelChart.Size = new System.Drawing.Size(200, 200);
            this.customPanelChart.TabIndex = 3;
            this.customPanelChart.Click += new System.EventHandler(this.customPanelChart_Click);
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChart.BackgroundImage = global::GigFinder.Properties.Resources.grafico;
            this.pictureBoxChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChart.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.pictureBoxChart.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxChart.TabIndex = 2;
            this.pictureBoxChart.TabStop = false;
            this.pictureBoxChart.Click += new System.EventHandler(this.pictureBoxChart_Click);
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChart.ForeColor = System.Drawing.Color.White;
            this.labelChart.Location = new System.Drawing.Point(51, 146);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(99, 36);
            this.labelChart.TabIndex = 0;
            this.labelChart.Text = "Gáficos";
            this.labelChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChart.Click += new System.EventHandler(this.labelChart_Click);
            // 
            // ResumeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GigFinder.Properties.Resources.Fondo_escritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResumeDataForm";
            this.Text = "ResumeDataForm";
            this.Load += new System.EventHandler(this.ResumeDataForm_Load);
            this.customPanelMenu.ResumeLayout(false);
            this.customPanelCalendar.ResumeLayout(false);
            this.customPanelCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.customPanelMap.ResumeLayout(false);
            this.customPanelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.customPanelChart.ResumeLayout(false);
            this.customPanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel customPanelMenu;
        private Controls.CustomPanel customPanelCalendar;
        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.Label labelCalendar;
        private Controls.CustomPanel customPanelMap;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Label labelMap;
        private Controls.CustomPanel customPanelChart;
        private System.Windows.Forms.PictureBox pictureBoxChart;
        private System.Windows.Forms.Label labelChart;
    }
}