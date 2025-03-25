namespace GigFinder
{
    partial class ResolveIncidencesForm
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
            this.customComboBoxStatus = new GigFinder.Controls.CustomComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.roundedTextBoxNote = new GigFinder.Controls.RoundedTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonSave = new GigFinder.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // customComboBoxStatus
            // 
            this.customComboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxStatus.BorderSize = 2;
            this.customComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxStatus.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.customComboBoxStatus.IconColor = System.Drawing.Color.Black;
            this.customComboBoxStatus.Items.AddRange(new object[] {
            "ignores",
            "fixed"});
            this.customComboBoxStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxStatus.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxStatus.Location = new System.Drawing.Point(88, 226);
            this.customComboBoxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxStatus.Name = "customComboBoxStatus";
            this.customComboBoxStatus.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxStatus.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxStatus.TabIndex = 47;
            this.customComboBoxStatus.Texts = "Estado de resolución:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(89, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 23);
            this.labelName.TabIndex = 46;
            this.labelName.Text = "Nota de resolución:";
            // 
            // roundedTextBoxNote
            // 
            this.roundedTextBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxNote.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxNote.BorderRadius = 8;
            this.roundedTextBoxNote.BorderSize = 2;
            this.roundedTextBoxNote.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxNote.Location = new System.Drawing.Point(88, 106);
            this.roundedTextBoxNote.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxNote.Multiline = true;
            this.roundedTextBoxNote.Name = "roundedTextBoxNote";
            this.roundedTextBoxNote.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxNote.PasswordChar = false;
            this.roundedTextBoxNote.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxNote.PlaceholderText = "";
            this.roundedTextBoxNote.Size = new System.Drawing.Size(320, 102);
            this.roundedTextBoxNote.TabIndex = 45;
            this.roundedTextBoxNote.Texts = "";
            this.roundedTextBoxNote.UnderlinedStyle = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(481, 70);
            this.labelTitle.TabIndex = 44;
            this.labelTitle.Text = "Resolver incidencia";
            // 
            // roundedButtonCancel
            // 
            this.roundedButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundedButtonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonCancel.BorderRadius = 8;
            this.roundedButtonCancel.BorderSize = 0;
            this.roundedButtonCancel.FlatAppearance.BorderSize = 0;
            this.roundedButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCancel.Font = new System.Drawing.Font("Passion One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCancel.ForeColor = System.Drawing.Color.White;
            this.roundedButtonCancel.Location = new System.Drawing.Point(258, 289);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 51;
            this.roundedButtonCancel.Text = "Cancelar";
            this.roundedButtonCancel.UseVisualStyleBackColor = false;
            this.roundedButtonCancel.Click += new System.EventHandler(this.roundedButtonCancel_Click);
            // 
            // roundedButtonSave
            // 
            this.roundedButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonSave.BorderRadius = 8;
            this.roundedButtonSave.BorderSize = 0;
            this.roundedButtonSave.FlatAppearance.BorderSize = 0;
            this.roundedButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonSave.Font = new System.Drawing.Font("Passion One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSave.ForeColor = System.Drawing.Color.White;
            this.roundedButtonSave.Location = new System.Drawing.Point(88, 289);
            this.roundedButtonSave.Name = "roundedButtonSave";
            this.roundedButtonSave.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonSave.TabIndex = 50;
            this.roundedButtonSave.Text = "Guardar";
            this.roundedButtonSave.UseVisualStyleBackColor = false;
            this.roundedButtonSave.Click += new System.EventHandler(this.roundedButtonSave_Click);
            // 
            // ResolveIncidencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonSave);
            this.Controls.Add(this.customComboBoxStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundedTextBoxNote);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResolveIncidencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResolveIncidencesForm";
            this.Load += new System.EventHandler(this.ResolveIncidencesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CustomComboBox customComboBoxStatus;
        private System.Windows.Forms.Label labelName;
        private Controls.RoundedTextBox roundedTextBoxNote;
        private System.Windows.Forms.Label labelTitle;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonSave;
    }
}