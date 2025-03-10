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
            this.SuspendLayout();
            // 
            // customPanelLogin
            // 
            this.customPanelLogin.BackColor = System.Drawing.Color.White;
            this.customPanelLogin.BorderRadius = 8;
            this.customPanelLogin.Location = new System.Drawing.Point(300, 50);
            this.customPanelLogin.Name = "customPanelLogin";
            this.customPanelLogin.Size = new System.Drawing.Size(600, 550);
            this.customPanelLogin.TabIndex = 1;
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
            this.Name = "SelectAccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAccessForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel customPanelLogin;
    }
}