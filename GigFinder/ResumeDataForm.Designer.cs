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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelGraphic1 = new System.Windows.Forms.Label();
            this.labelGraphic2 = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.labelCalendar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 50F);
            this.labelTitle.Location = new System.Drawing.Point(6, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(483, 74);
            this.labelTitle.TabIndex = 3;
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
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelGraphic1
            // 
            this.labelGraphic1.AutoSize = true;
            this.labelGraphic1.Font = new System.Drawing.Font("Passion One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphic1.Location = new System.Drawing.Point(12, 94);
            this.labelGraphic1.Name = "labelGraphic1";
            this.labelGraphic1.Size = new System.Drawing.Size(253, 41);
            this.labelGraphic1.TabIndex = 4;
            this.labelGraphic1.Text = "Tipos de usuarios";
            // 
            // labelGraphic2
            // 
            this.labelGraphic2.AutoSize = true;
            this.labelGraphic2.Font = new System.Drawing.Font("Passion One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphic2.Location = new System.Drawing.Point(371, 94);
            this.labelGraphic2.Name = "labelGraphic2";
            this.labelGraphic2.Size = new System.Drawing.Size(318, 41);
            this.labelGraphic2.TabIndex = 5;
            this.labelGraphic2.Text = "Géneros mas comunes";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Passion One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.Location = new System.Drawing.Point(781, 103);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(292, 41);
            this.labelMap.TabIndex = 6;
            this.labelMap.Text = "Ubicación de locales";
            // 
            // labelCalendar
            // 
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Font = new System.Drawing.Font("Passion One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendar.Location = new System.Drawing.Point(142, 331);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(313, 41);
            this.labelCalendar.TabIndex = 7;
            this.labelCalendar.Text = "Eventos programados";
            // 
            // ResumeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.labelCalendar);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.labelGraphic2);
            this.Controls.Add(this.labelGraphic1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResumeDataForm";
            this.Text = "ResumeDataForm";
            this.Load += new System.EventHandler(this.ResumeDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelGraphic1;
        private System.Windows.Forms.Label labelGraphic2;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Label labelCalendar;
    }
}