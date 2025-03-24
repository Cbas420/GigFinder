namespace GigFinder
{
    partial class ManageDatabaseForm
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
            this.customPanelIncidencies = new GigFinder.Controls.CustomPanel();
            this.pictureBoxIncidencies = new System.Windows.Forms.PictureBox();
            this.labelIncidencies = new System.Windows.Forms.Label();
            this.customPanelRatings = new GigFinder.Controls.CustomPanel();
            this.pictureBoxRatings = new System.Windows.Forms.PictureBox();
            this.labelRatings = new System.Windows.Forms.Label();
            this.customPanelLocals = new GigFinder.Controls.CustomPanel();
            this.pictureBoxLocals = new System.Windows.Forms.PictureBox();
            this.labelLocals = new System.Windows.Forms.Label();
            this.customPanelMusicians = new GigFinder.Controls.CustomPanel();
            this.pictureBoxMusicians = new System.Windows.Forms.PictureBox();
            this.labelMusicians = new System.Windows.Forms.Label();
            this.customPanelLogin.SuspendLayout();
            this.customPanelIncidencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncidencies)).BeginInit();
            this.customPanelRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRatings)).BeginInit();
            this.customPanelLocals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocals)).BeginInit();
            this.customPanelMusicians.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicians)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanelLogin
            // 
            this.customPanelLogin.BackColor = System.Drawing.Color.White;
            this.customPanelLogin.BorderRadius = 8;
            this.customPanelLogin.Controls.Add(this.customPanelIncidencies);
            this.customPanelLogin.Controls.Add(this.customPanelRatings);
            this.customPanelLogin.Controls.Add(this.customPanelLocals);
            this.customPanelLogin.Controls.Add(this.customPanelMusicians);
            this.customPanelLogin.Location = new System.Drawing.Point(292, 55);
            this.customPanelLogin.Name = "customPanelLogin";
            this.customPanelLogin.Size = new System.Drawing.Size(600, 550);
            this.customPanelLogin.TabIndex = 2;
            // 
            // customPanelIncidencies
            // 
            this.customPanelIncidencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelIncidencies.BorderRadius = 8;
            this.customPanelIncidencies.Controls.Add(this.pictureBoxIncidencies);
            this.customPanelIncidencies.Controls.Add(this.labelIncidencies);
            this.customPanelIncidencies.Location = new System.Drawing.Point(60, 300);
            this.customPanelIncidencies.Name = "customPanelIncidencies";
            this.customPanelIncidencies.Size = new System.Drawing.Size(200, 200);
            this.customPanelIncidencies.TabIndex = 3;
            // 
            // pictureBoxIncidencies
            // 
            this.pictureBoxIncidencies.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIncidencies.BackgroundImage = global::GigFinder.Properties.Resources.llamada_de_emergencia;
            this.pictureBoxIncidencies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIncidencies.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxIncidencies.Name = "pictureBoxIncidencies";
            this.pictureBoxIncidencies.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxIncidencies.TabIndex = 3;
            this.pictureBoxIncidencies.TabStop = false;
            // 
            // labelIncidencies
            // 
            this.labelIncidencies.AutoSize = true;
            this.labelIncidencies.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncidencies.ForeColor = System.Drawing.Color.White;
            this.labelIncidencies.Location = new System.Drawing.Point(30, 128);
            this.labelIncidencies.Name = "labelIncidencies";
            this.labelIncidencies.Size = new System.Drawing.Size(142, 72);
            this.labelIncidencies.TabIndex = 0;
            this.labelIncidencies.Text = "Gestión de\r\nincidencias";
            this.labelIncidencies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customPanelRatings
            // 
            this.customPanelRatings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelRatings.BorderRadius = 8;
            this.customPanelRatings.Controls.Add(this.pictureBoxRatings);
            this.customPanelRatings.Controls.Add(this.labelRatings);
            this.customPanelRatings.Location = new System.Drawing.Point(340, 300);
            this.customPanelRatings.Name = "customPanelRatings";
            this.customPanelRatings.Size = new System.Drawing.Size(200, 200);
            this.customPanelRatings.TabIndex = 3;
            // 
            // pictureBoxRatings
            // 
            this.pictureBoxRatings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRatings.BackgroundImage = global::GigFinder.Properties.Resources.buena_resena;
            this.pictureBoxRatings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRatings.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxRatings.Name = "pictureBoxRatings";
            this.pictureBoxRatings.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxRatings.TabIndex = 4;
            this.pictureBoxRatings.TabStop = false;
            // 
            // labelRatings
            // 
            this.labelRatings.AutoSize = true;
            this.labelRatings.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatings.ForeColor = System.Drawing.Color.White;
            this.labelRatings.Location = new System.Drawing.Point(20, 128);
            this.labelRatings.Name = "labelRatings";
            this.labelRatings.Size = new System.Drawing.Size(162, 72);
            this.labelRatings.TabIndex = 0;
            this.labelRatings.Text = "Gestión de\r\nvaloraciones";
            this.labelRatings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customPanelLocals
            // 
            this.customPanelLocals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelLocals.BorderRadius = 8;
            this.customPanelLocals.Controls.Add(this.pictureBoxLocals);
            this.customPanelLocals.Controls.Add(this.labelLocals);
            this.customPanelLocals.Location = new System.Drawing.Point(340, 50);
            this.customPanelLocals.Name = "customPanelLocals";
            this.customPanelLocals.Size = new System.Drawing.Size(200, 200);
            this.customPanelLocals.TabIndex = 3;
            // 
            // pictureBoxLocals
            // 
            this.pictureBoxLocals.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLocals.BackgroundImage = global::GigFinder.Properties.Resources.compra_local;
            this.pictureBoxLocals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLocals.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxLocals.Name = "pictureBoxLocals";
            this.pictureBoxLocals.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxLocals.TabIndex = 2;
            this.pictureBoxLocals.TabStop = false;
            // 
            // labelLocals
            // 
            this.labelLocals.AutoSize = true;
            this.labelLocals.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocals.ForeColor = System.Drawing.Color.White;
            this.labelLocals.Location = new System.Drawing.Point(30, 128);
            this.labelLocals.Name = "labelLocals";
            this.labelLocals.Size = new System.Drawing.Size(140, 72);
            this.labelLocals.TabIndex = 0;
            this.labelLocals.Text = "Gestión de\r\nlocales";
            this.labelLocals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customPanelMusicians
            // 
            this.customPanelMusicians.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customPanelMusicians.BorderRadius = 8;
            this.customPanelMusicians.Controls.Add(this.pictureBoxMusicians);
            this.customPanelMusicians.Controls.Add(this.labelMusicians);
            this.customPanelMusicians.Location = new System.Drawing.Point(60, 50);
            this.customPanelMusicians.Name = "customPanelMusicians";
            this.customPanelMusicians.Size = new System.Drawing.Size(200, 200);
            this.customPanelMusicians.TabIndex = 2;
            // 
            // pictureBoxMusicians
            // 
            this.pictureBoxMusicians.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusicians.BackgroundImage = global::GigFinder.Properties.Resources.banda;
            this.pictureBoxMusicians.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMusicians.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxMusicians.Name = "pictureBoxMusicians";
            this.pictureBoxMusicians.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxMusicians.TabIndex = 1;
            this.pictureBoxMusicians.TabStop = false;
            // 
            // labelMusicians
            // 
            this.labelMusicians.AutoSize = true;
            this.labelMusicians.Font = new System.Drawing.Font("Passion One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicians.ForeColor = System.Drawing.Color.White;
            this.labelMusicians.Location = new System.Drawing.Point(30, 128);
            this.labelMusicians.Name = "labelMusicians";
            this.labelMusicians.Size = new System.Drawing.Size(140, 72);
            this.labelMusicians.TabIndex = 0;
            this.labelMusicians.Text = "Gestión de\r\nmúsicos";
            this.labelMusicians.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GigFinder.Properties.Resources.Fondo_escritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageDatabaseForm";
            this.Text = "ManageDatabaseForm";
            this.Load += new System.EventHandler(this.ManageDatabaseForm_Load);
            this.customPanelLogin.ResumeLayout(false);
            this.customPanelIncidencies.ResumeLayout(false);
            this.customPanelIncidencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncidencies)).EndInit();
            this.customPanelRatings.ResumeLayout(false);
            this.customPanelRatings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRatings)).EndInit();
            this.customPanelLocals.ResumeLayout(false);
            this.customPanelLocals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocals)).EndInit();
            this.customPanelMusicians.ResumeLayout(false);
            this.customPanelMusicians.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel customPanelLogin;
        private Controls.CustomPanel customPanelIncidencies;
        private System.Windows.Forms.PictureBox pictureBoxIncidencies;
        private System.Windows.Forms.Label labelIncidencies;
        private Controls.CustomPanel customPanelRatings;
        private System.Windows.Forms.PictureBox pictureBoxRatings;
        private System.Windows.Forms.Label labelRatings;
        private Controls.CustomPanel customPanelLocals;
        private System.Windows.Forms.PictureBox pictureBoxLocals;
        private System.Windows.Forms.Label labelLocals;
        private Controls.CustomPanel customPanelMusicians;
        private System.Windows.Forms.PictureBox pictureBoxMusicians;
        private System.Windows.Forms.Label labelMusicians;
    }
}