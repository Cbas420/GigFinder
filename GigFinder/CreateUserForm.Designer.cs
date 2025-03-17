namespace GigFinder
{
    partial class CreateUserForm
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
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.roundedTextBoxConfirmPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxMail = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxName = new GigFinder.Controls.RoundedTextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.roundedTextBoxSurname = new GigFinder.Controls.RoundedTextBox();
            this.customComboBoxType = new GigFinder.Controls.CustomComboBox();
            this.roundedButtonCreate = new GigFinder.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(24, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(339, 70);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Crear usuario";
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.Location = new System.Drawing.Point(33, 369);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(179, 23);
            this.labelConfirmPass.TabIndex = 40;
            this.labelConfirmPass.Text = "Confirmar contraseña:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(33, 301);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(101, 23);
            this.labelPass.TabIndex = 39;
            this.labelPass.Text = "Contraseña:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(33, 234);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(68, 23);
            this.labelMail.TabIndex = 38;
            this.labelMail.Text = "Correo:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(33, 95);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 23);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Nombre:";
            // 
            // roundedTextBoxConfirmPass
            // 
            this.roundedTextBoxConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxConfirmPass.BorderRadius = 8;
            this.roundedTextBoxConfirmPass.BorderSize = 2;
            this.roundedTextBoxConfirmPass.Location = new System.Drawing.Point(32, 395);
            this.roundedTextBoxConfirmPass.Multiline = false;
            this.roundedTextBoxConfirmPass.Name = "roundedTextBoxConfirmPass";
            this.roundedTextBoxConfirmPass.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxConfirmPass.PasswordChar = false;
            this.roundedTextBoxConfirmPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.PlaceholderText = "";
            this.roundedTextBoxConfirmPass.Size = new System.Drawing.Size(320, 34);
            this.roundedTextBoxConfirmPass.TabIndex = 36;
            this.roundedTextBoxConfirmPass.Texts = "";
            this.roundedTextBoxConfirmPass.UnderlinedStyle = false;
            // 
            // roundedTextBoxPass
            // 
            this.roundedTextBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPass.BorderRadius = 8;
            this.roundedTextBoxPass.BorderSize = 2;
            this.roundedTextBoxPass.Location = new System.Drawing.Point(32, 327);
            this.roundedTextBoxPass.Multiline = false;
            this.roundedTextBoxPass.Name = "roundedTextBoxPass";
            this.roundedTextBoxPass.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxPass.PasswordChar = false;
            this.roundedTextBoxPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.PlaceholderText = "";
            this.roundedTextBoxPass.Size = new System.Drawing.Size(320, 34);
            this.roundedTextBoxPass.TabIndex = 35;
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
            this.roundedTextBoxMail.Location = new System.Drawing.Point(32, 260);
            this.roundedTextBoxMail.Multiline = false;
            this.roundedTextBoxMail.Name = "roundedTextBoxMail";
            this.roundedTextBoxMail.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxMail.PasswordChar = false;
            this.roundedTextBoxMail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.PlaceholderText = "";
            this.roundedTextBoxMail.Size = new System.Drawing.Size(320, 34);
            this.roundedTextBoxMail.TabIndex = 34;
            this.roundedTextBoxMail.Texts = "";
            this.roundedTextBoxMail.UnderlinedStyle = false;
            // 
            // roundedTextBoxName
            // 
            this.roundedTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxName.BorderRadius = 8;
            this.roundedTextBoxName.BorderSize = 2;
            this.roundedTextBoxName.Location = new System.Drawing.Point(32, 121);
            this.roundedTextBoxName.Multiline = false;
            this.roundedTextBoxName.Name = "roundedTextBoxName";
            this.roundedTextBoxName.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxName.PasswordChar = false;
            this.roundedTextBoxName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.PlaceholderText = "";
            this.roundedTextBoxName.Size = new System.Drawing.Size(320, 34);
            this.roundedTextBoxName.TabIndex = 33;
            this.roundedTextBoxName.Texts = "";
            this.roundedTextBoxName.UnderlinedStyle = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(33, 164);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 23);
            this.labelSurname.TabIndex = 42;
            this.labelSurname.Text = "Apellido:";
            // 
            // roundedTextBoxSurname
            // 
            this.roundedTextBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSurname.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxSurname.BorderRadius = 8;
            this.roundedTextBoxSurname.BorderSize = 2;
            this.roundedTextBoxSurname.Location = new System.Drawing.Point(32, 190);
            this.roundedTextBoxSurname.Multiline = false;
            this.roundedTextBoxSurname.Name = "roundedTextBoxSurname";
            this.roundedTextBoxSurname.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxSurname.PasswordChar = false;
            this.roundedTextBoxSurname.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSurname.PlaceholderText = "";
            this.roundedTextBoxSurname.Size = new System.Drawing.Size(320, 34);
            this.roundedTextBoxSurname.TabIndex = 41;
            this.roundedTextBoxSurname.Texts = "";
            this.roundedTextBoxSurname.UnderlinedStyle = false;
            // 
            // customComboBoxType
            // 
            this.customComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxType.BorderSize = 2;
            this.customComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxType.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxType.ForeColor = System.Drawing.Color.Black;
            this.customComboBoxType.IconColor = System.Drawing.Color.Black;
            this.customComboBoxType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxType.Location = new System.Drawing.Point(32, 450);
            this.customComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxType.Name = "customComboBoxType";
            this.customComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxType.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxType.TabIndex = 43;
            this.customComboBoxType.Texts = "Tipo de usuario";
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonCreate.BorderRadius = 8;
            this.roundedButtonCreate.BorderSize = 0;
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.Font = new System.Drawing.Font("Passion One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.White;
            this.roundedButtonCreate.Location = new System.Drawing.Point(202, 509);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCreate.TabIndex = 44;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.customComboBoxType);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.roundedTextBoxSurname);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundedTextBoxConfirmPass);
            this.Controls.Add(this.roundedTextBoxPass);
            this.Controls.Add(this.roundedTextBoxMail);
            this.Controls.Add(this.roundedTextBoxName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelName;
        private Controls.RoundedTextBox roundedTextBoxConfirmPass;
        private Controls.RoundedTextBox roundedTextBoxPass;
        private Controls.RoundedTextBox roundedTextBoxMail;
        private Controls.RoundedTextBox roundedTextBoxName;
        private System.Windows.Forms.Label labelSurname;
        private Controls.RoundedTextBox roundedTextBoxSurname;
        private Controls.CustomComboBox customComboBoxType;
        private Controls.RoundedButton roundedButtonCreate;
    }
}