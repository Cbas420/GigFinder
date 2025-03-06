namespace GigFinder
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
            this.roundedTextBox1 = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBox2 = new GigFinder.Controls.RoundedTextBox();
            this.SuspendLayout();
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundedTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBox1.BorderRadius = 8;
            this.roundedTextBox1.BorderSize = 2;
            this.roundedTextBox1.Location = new System.Drawing.Point(177, 99);
            this.roundedTextBox1.Multiline = false;
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBox1.PasswordChar = false;
            this.roundedTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBox1.PlaceholderText = "";
            this.roundedTextBox1.Size = new System.Drawing.Size(250, 34);
            this.roundedTextBox1.TabIndex = 0;
            this.roundedTextBox1.Texts = "";
            this.roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedTextBox2
            // 
            this.roundedTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.roundedTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBox2.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBox2.BorderRadius = 8;
            this.roundedTextBox2.BorderSize = 2;
            this.roundedTextBox2.Location = new System.Drawing.Point(177, 154);
            this.roundedTextBox2.Multiline = false;
            this.roundedTextBox2.Name = "roundedTextBox2";
            this.roundedTextBox2.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBox2.PasswordChar = false;
            this.roundedTextBox2.PlaceholderColor = System.Drawing.Color.Black;
            this.roundedTextBox2.PlaceholderText = "";
            this.roundedTextBox2.Size = new System.Drawing.Size(250, 34);
            this.roundedTextBox2.TabIndex = 1;
            this.roundedTextBox2.Texts = "";
            this.roundedTextBox2.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 424);
            this.Controls.Add(this.roundedTextBox2);
            this.Controls.Add(this.roundedTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedTextBox roundedTextBox1;
        private Controls.RoundedTextBox roundedTextBox2;
    }
}

