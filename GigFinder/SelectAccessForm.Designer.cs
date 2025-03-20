namespace GigFinder
{
    partial class SelectAccessForm
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
            this.customPanelLogin = new GigFinder.Controls.CustomPanel();
            this.customPanelStats = new GigFinder.Controls.CustomPanel();
            this.pictureBoxStats = new System.Windows.Forms.PictureBox();
            this.labelStats = new System.Windows.Forms.Label();
            this.customPanelRegister = new GigFinder.Controls.CustomPanel();
            this.pictureBoxRegister = new System.Windows.Forms.PictureBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.customPanelData = new GigFinder.Controls.CustomPanel();
            this.pictureBoxData = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            this.customPanelUsers = new GigFinder.Controls.CustomPanel();
            this.pictureBoxUsers = new System.Windows.Forms.PictureBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.customPanelLogin.SuspendLayout();
            this.customPanelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStats)).BeginInit();
            this.customPanelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).BeginInit();
            this.customPanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData)).BeginInit();
            this.customPanelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanelLogin
            // 
            this.customPanelLogin.BackColor = System.Drawing.Color.White;
            this.customPanelLogin.BorderRadius = 8;
            this.customPanelLogin.Controls.Add(this.customPanelStats);
            this.customPanelLogin.Controls.Add(this.customPanelRegister);
            this.customPanelLogin.Controls.Add(this.customPanelData);
            this.customPanelLogin.Controls.Add(this.customPanelUsers);
            this.customPanelLogin.Location = new System.Drawing.Point(300, 50);
            this.customPanelLogin.Name = "customPanelLogin";
            this.customPanelLogin.Size = new System.Drawing.Size(600, 550);
            this.customPanelLogin.TabIndex = 1;
            // 
            // customPanelStats
            // 
            this.customPanelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelStats.BorderRadius = 8;
            this.customPanelStats.Controls.Add(this.pictureBoxStats);
            this.customPanelStats.Controls.Add(this.labelStats);
            this.customPanelStats.Location = new System.Drawing.Point(60, 300);
            this.customPanelStats.Name = "customPanelStats";
            this.customPanelStats.Size = new System.Drawing.Size(200, 200);
            this.customPanelStats.TabIndex = 3;
            this.customPanelStats.Click += new System.EventHandler(this.customPanelStats_Click);
            // 
            // pictureBoxStats
            // 
            this.pictureBoxStats.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStats.BackgroundImage = global::GigFinder.Properties.Resources.ImageMonitor;
            this.pictureBoxStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStats.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxStats.Name = "pictureBoxStats";
            this.pictureBoxStats.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxStats.TabIndex = 3;
            this.pictureBoxStats.TabStop = false;
            this.pictureBoxStats.Click += new System.EventHandler(this.pictureBoxStats_Click);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStats.ForeColor = System.Drawing.Color.White;
            this.labelStats.Location = new System.Drawing.Point(21, 128);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(159, 72);
            this.labelStats.TabIndex = 0;
            this.labelStats.Text = "Resumen de\r\ndatos";
            this.labelStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStats.Click += new System.EventHandler(this.labelStats_Click);
            // 
            // customPanelRegister
            // 
            this.customPanelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelRegister.BorderRadius = 8;
            this.customPanelRegister.Controls.Add(this.pictureBoxRegister);
            this.customPanelRegister.Controls.Add(this.labelRegister);
            this.customPanelRegister.Location = new System.Drawing.Point(340, 300);
            this.customPanelRegister.Name = "customPanelRegister";
            this.customPanelRegister.Size = new System.Drawing.Size(200, 200);
            this.customPanelRegister.TabIndex = 3;
            this.customPanelRegister.Click += new System.EventHandler(this.customPanelRegister_Click);
            // 
            // pictureBoxRegister
            // 
            this.pictureBoxRegister.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRegister.BackgroundImage = global::GigFinder.Properties.Resources.ImageActivity;
            this.pictureBoxRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRegister.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxRegister.Name = "pictureBoxRegister";
            this.pictureBoxRegister.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxRegister.TabIndex = 4;
            this.pictureBoxRegister.TabStop = false;
            this.pictureBoxRegister.Click += new System.EventHandler(this.pictureBoxRegister_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(31, 128);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(138, 72);
            this.labelRegister.TabIndex = 0;
            this.labelRegister.Text = "Registo de\r\nactividad";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // customPanelData
            // 
            this.customPanelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelData.BorderRadius = 8;
            this.customPanelData.Controls.Add(this.pictureBoxData);
            this.customPanelData.Controls.Add(this.labelData);
            this.customPanelData.Location = new System.Drawing.Point(340, 50);
            this.customPanelData.Name = "customPanelData";
            this.customPanelData.Size = new System.Drawing.Size(200, 200);
            this.customPanelData.TabIndex = 3;
            this.customPanelData.Click += new System.EventHandler(this.customPanelData_Click);
            // 
            // pictureBoxData
            // 
            this.pictureBoxData.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxData.BackgroundImage = global::GigFinder.Properties.Resources.ImageData;
            this.pictureBoxData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxData.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxData.Name = "pictureBoxData";
            this.pictureBoxData.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxData.TabIndex = 2;
            this.pictureBoxData.TabStop = false;
            this.pictureBoxData.Click += new System.EventHandler(this.pictureBoxData_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(30, 128);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(140, 72);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Gestión de\r\ndatos";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // customPanelUsers
            // 
            this.customPanelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelUsers.BorderRadius = 8;
            this.customPanelUsers.Controls.Add(this.pictureBoxUsers);
            this.customPanelUsers.Controls.Add(this.labelUsers);
            this.customPanelUsers.Location = new System.Drawing.Point(60, 50);
            this.customPanelUsers.Name = "customPanelUsers";
            this.customPanelUsers.Size = new System.Drawing.Size(200, 200);
            this.customPanelUsers.TabIndex = 2;
            this.customPanelUsers.Click += new System.EventHandler(this.customPanelUsers_Click);
            // 
            // pictureBoxUsers
            // 
            this.pictureBoxUsers.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsers.BackgroundImage = global::GigFinder.Properties.Resources.ImageUsers;
            this.pictureBoxUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUsers.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxUsers.Name = "pictureBoxUsers";
            this.pictureBoxUsers.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxUsers.TabIndex = 1;
            this.pictureBoxUsers.TabStop = false;
            this.pictureBoxUsers.Click += new System.EventHandler(this.pictureBoxUsers_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.White;
            this.labelUsers.Location = new System.Drawing.Point(30, 128);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(140, 72);
            this.labelUsers.TabIndex = 0;
            this.labelUsers.Text = "Gestión de\r\nusuarios";
            this.labelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUsers.Click += new System.EventHandler(this.labelUsers_Click);
            // 
            // SelectAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GigFinder.Properties.Resources.Fondo_escritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectAccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAccessForm";
            this.customPanelLogin.ResumeLayout(false);
            this.customPanelStats.ResumeLayout(false);
            this.customPanelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStats)).EndInit();
            this.customPanelRegister.ResumeLayout(false);
            this.customPanelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).EndInit();
            this.customPanelData.ResumeLayout(false);
            this.customPanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxData)).EndInit();
            this.customPanelUsers.ResumeLayout(false);
            this.customPanelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel customPanelLogin;
        private Controls.CustomPanel customPanelUsers;
        private Controls.CustomPanel customPanelStats;
        private Controls.CustomPanel customPanelRegister;
        private Controls.CustomPanel customPanelData;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.PictureBox pictureBoxStats;
        private System.Windows.Forms.PictureBox pictureBoxRegister;
        private System.Windows.Forms.PictureBox pictureBoxData;
        private System.Windows.Forms.PictureBox pictureBoxUsers;
    }
}