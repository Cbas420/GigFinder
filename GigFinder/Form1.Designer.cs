﻿namespace GigFinder
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.customPanelLogin = new GigFinder.Controls.CustomPanel();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.roundedButtonLogin = new GigFinder.Controls.RoundedButton();
            this.roundedTextBoxPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxMail = new GigFinder.Controls.RoundedTextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxES = new System.Windows.Forms.PictureBox();
            this.pictureBoxEN = new System.Windows.Forms.PictureBox();
            this.pictureBoxCA = new System.Windows.Forms.PictureBox();
            this.customPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCA)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanelLogin
            // 
            this.customPanelLogin.BackColor = System.Drawing.Color.White;
            this.customPanelLogin.BorderRadius = 8;
            this.customPanelLogin.Controls.Add(this.labelPass);
            this.customPanelLogin.Controls.Add(this.labelMail);
            this.customPanelLogin.Controls.Add(this.roundedButtonLogin);
            this.customPanelLogin.Controls.Add(this.roundedTextBoxPass);
            this.customPanelLogin.Controls.Add(this.roundedTextBoxMail);
            this.customPanelLogin.Controls.Add(this.pictureBoxLogo);
            this.customPanelLogin.Location = new System.Drawing.Point(300, 50);
            this.customPanelLogin.Name = "customPanelLogin";
            this.customPanelLogin.Size = new System.Drawing.Size(600, 550);
            this.customPanelLogin.TabIndex = 0;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(154, 344);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(120, 27);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Contraseña:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(154, 255);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(78, 27);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Correo:";
            // 
            // roundedButtonLogin
            // 
            this.roundedButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonLogin.BorderRadius = 8;
            this.roundedButtonLogin.BorderSize = 0;
            this.roundedButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundedButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonLogin.Font = new System.Drawing.Font("Passion One", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLogin.ForeColor = System.Drawing.Color.White;
            this.roundedButtonLogin.Location = new System.Drawing.Point(199, 466);
            this.roundedButtonLogin.Name = "roundedButtonLogin";
            this.roundedButtonLogin.Size = new System.Drawing.Size(200, 50);
            this.roundedButtonLogin.TabIndex = 3;
            this.roundedButtonLogin.Text = "Entrar";
            this.roundedButtonLogin.UseVisualStyleBackColor = false;
            this.roundedButtonLogin.Click += new System.EventHandler(this.roundedButtonLogin_Click);
            // 
            // roundedTextBoxPass
            // 
            this.roundedTextBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPass.BorderRadius = 8;
            this.roundedTextBoxPass.BorderSize = 2;
            this.roundedTextBoxPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPass.Location = new System.Drawing.Point(150, 374);
            this.roundedTextBoxPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxPass.Multiline = false;
            this.roundedTextBoxPass.Name = "roundedTextBoxPass";
            this.roundedTextBoxPass.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxPass.PasswordChar = true;
            this.roundedTextBoxPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.PlaceholderText = "";
            this.roundedTextBoxPass.Size = new System.Drawing.Size(300, 44);
            this.roundedTextBoxPass.TabIndex = 2;
            this.roundedTextBoxPass.Texts = "";
            this.roundedTextBoxPass.UnderlinedStyle = false;
            // 
            // roundedTextBoxMail
            // 
            this.roundedTextBoxMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxMail.BorderRadius = 8;
            this.roundedTextBoxMail.BorderSize = 2;
            this.roundedTextBoxMail.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxMail.Location = new System.Drawing.Point(150, 285);
            this.roundedTextBoxMail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxMail.Multiline = false;
            this.roundedTextBoxMail.Name = "roundedTextBoxMail";
            this.roundedTextBoxMail.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxMail.PasswordChar = false;
            this.roundedTextBoxMail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.PlaceholderText = "";
            this.roundedTextBoxMail.Size = new System.Drawing.Size(300, 44);
            this.roundedTextBoxMail.TabIndex = 1;
            this.roundedTextBoxMail.Texts = "";
            this.roundedTextBoxMail.UnderlinedStyle = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::GigFinder.Properties.Resources.logo1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(215, 35);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(170, 200);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxES
            // 
            this.pictureBoxES.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxES.BackgroundImage = global::GigFinder.Properties.Resources.espana;
            this.pictureBoxES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxES.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxES.Name = "pictureBoxES";
            this.pictureBoxES.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxES.TabIndex = 1;
            this.pictureBoxES.TabStop = false;
            this.pictureBoxES.Click += new System.EventHandler(this.pictureBoxES_Click);
            // 
            // pictureBoxEN
            // 
            this.pictureBoxEN.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEN.BackgroundImage = global::GigFinder.Properties.Resources.reino_unido;
            this.pictureBoxEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEN.Location = new System.Drawing.Point(58, 12);
            this.pictureBoxEN.Name = "pictureBoxEN";
            this.pictureBoxEN.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxEN.TabIndex = 2;
            this.pictureBoxEN.TabStop = false;
            this.pictureBoxEN.Click += new System.EventHandler(this.pictureBoxEN_Click);
            // 
            // pictureBoxCA
            // 
            this.pictureBoxCA.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCA.BackgroundImage = global::GigFinder.Properties.Resources.bandera;
            this.pictureBoxCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCA.Location = new System.Drawing.Point(104, 12);
            this.pictureBoxCA.Name = "pictureBoxCA";
            this.pictureBoxCA.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCA.TabIndex = 3;
            this.pictureBoxCA.TabStop = false;
            this.pictureBoxCA.Click += new System.EventHandler(this.pictureBoxCA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GigFinder.Properties.Resources.Fondo_escritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pictureBoxCA);
            this.Controls.Add(this.pictureBoxEN);
            this.Controls.Add(this.pictureBoxES);
            this.Controls.Add(this.customPanelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GigFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customPanelLogin.ResumeLayout(false);
            this.customPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel customPanelLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Controls.RoundedTextBox roundedTextBoxPass;
        private Controls.RoundedTextBox roundedTextBoxMail;
        private Controls.RoundedButton roundedButtonLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.PictureBox pictureBoxES;
        private System.Windows.Forms.PictureBox pictureBoxEN;
        private System.Windows.Forms.PictureBox pictureBoxCA;
    }
}

