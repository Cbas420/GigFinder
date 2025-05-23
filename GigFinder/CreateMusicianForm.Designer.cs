﻿namespace GigFinder
{
    partial class CreateMusicianForm
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
            this.components = new System.ComponentModel.Container();
            this.labelGroupSize = new System.Windows.Forms.Label();
            this.labelPrize = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.bindingSourceGenres = new System.Windows.Forms.BindingSource(this.components);
            this.roundedTextBoxDescription = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxConfirmPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxSizeGroup = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxPrice = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxMail = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxName = new GigFinder.Controls.RoundedTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.customComboBoxLang = new GigFinder.Controls.CustomComboBox();
            this.bindingSourceLang = new System.Windows.Forms.BindingSource(this.components);
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonCreate = new GigFinder.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroupSize
            // 
            this.labelGroupSize.AutoSize = true;
            this.labelGroupSize.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupSize.Location = new System.Drawing.Point(430, 213);
            this.labelGroupSize.Name = "labelGroupSize";
            this.labelGroupSize.Size = new System.Drawing.Size(153, 23);
            this.labelGroupSize.TabIndex = 37;
            this.labelGroupSize.Text = "Tamaño del grupo:";
            // 
            // labelPrize
            // 
            this.labelPrize.AutoSize = true;
            this.labelPrize.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrize.Location = new System.Drawing.Point(430, 143);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(186, 23);
            this.labelPrize.TabIndex = 36;
            this.labelPrize.Text = "Precio de contratación:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(40, 359);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 23);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "Descripción:";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenres.Location = new System.Drawing.Point(422, 289);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(157, 23);
            this.labelGenres.TabIndex = 33;
            this.labelGenres.Text = "Géneros musicales:";
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.Location = new System.Drawing.Point(40, 284);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(179, 23);
            this.labelConfirmPass.TabIndex = 32;
            this.labelConfirmPass.Text = "Confirmar contraseña:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(40, 213);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(101, 23);
            this.labelPass.TabIndex = 31;
            this.labelPass.Text = "Contraseña:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(40, 143);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(68, 23);
            this.labelMail.TabIndex = 30;
            this.labelMail.Text = "Correo:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(40, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 23);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Nombre:";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.listBoxGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGenres.DataSource = this.bindingSourceGenres;
            this.listBoxGenres.DisplayMember = "name";
            this.listBoxGenres.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 23;
            this.listBoxGenres.Location = new System.Drawing.Point(426, 315);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGenres.Size = new System.Drawing.Size(320, 276);
            this.listBoxGenres.TabIndex = 9;
            this.listBoxGenres.ValueMember = "id";
            // 
            // bindingSourceGenres
            // 
            this.bindingSourceGenres.DataSource = typeof(GigFinder.Models.Genres);
            // 
            // roundedTextBoxDescription
            // 
            this.roundedTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxDescription.BorderRadius = 8;
            this.roundedTextBoxDescription.BorderSize = 2;
            this.roundedTextBoxDescription.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxDescription.Location = new System.Drawing.Point(39, 385);
            this.roundedTextBoxDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxDescription.Multiline = true;
            this.roundedTextBoxDescription.Name = "roundedTextBoxDescription";
            this.roundedTextBoxDescription.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxDescription.PasswordChar = false;
            this.roundedTextBoxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxDescription.PlaceholderText = "";
            this.roundedTextBoxDescription.Size = new System.Drawing.Size(320, 206);
            this.roundedTextBoxDescription.TabIndex = 5;
            this.roundedTextBoxDescription.Texts = "";
            this.roundedTextBoxDescription.UnderlinedStyle = false;
            // 
            // roundedTextBoxConfirmPass
            // 
            this.roundedTextBoxConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxConfirmPass.BorderRadius = 8;
            this.roundedTextBoxConfirmPass.BorderSize = 2;
            this.roundedTextBoxConfirmPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxConfirmPass.Location = new System.Drawing.Point(39, 310);
            this.roundedTextBoxConfirmPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxConfirmPass.Multiline = false;
            this.roundedTextBoxConfirmPass.Name = "roundedTextBoxConfirmPass";
            this.roundedTextBoxConfirmPass.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxConfirmPass.PasswordChar = true;
            this.roundedTextBoxConfirmPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.PlaceholderText = "";
            this.roundedTextBoxConfirmPass.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxConfirmPass.TabIndex = 4;
            this.roundedTextBoxConfirmPass.Texts = "";
            this.roundedTextBoxConfirmPass.UnderlinedStyle = false;
            // 
            // roundedTextBoxSizeGroup
            // 
            this.roundedTextBoxSizeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxSizeGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSizeGroup.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxSizeGroup.BorderRadius = 8;
            this.roundedTextBoxSizeGroup.BorderSize = 2;
            this.roundedTextBoxSizeGroup.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxSizeGroup.Location = new System.Drawing.Point(426, 239);
            this.roundedTextBoxSizeGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxSizeGroup.Multiline = false;
            this.roundedTextBoxSizeGroup.Name = "roundedTextBoxSizeGroup";
            this.roundedTextBoxSizeGroup.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxSizeGroup.PasswordChar = false;
            this.roundedTextBoxSizeGroup.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSizeGroup.PlaceholderText = "";
            this.roundedTextBoxSizeGroup.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxSizeGroup.TabIndex = 8;
            this.roundedTextBoxSizeGroup.Texts = "";
            this.roundedTextBoxSizeGroup.UnderlinedStyle = false;
            // 
            // roundedTextBoxPrice
            // 
            this.roundedTextBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPrice.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPrice.BorderRadius = 8;
            this.roundedTextBoxPrice.BorderSize = 2;
            this.roundedTextBoxPrice.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPrice.Location = new System.Drawing.Point(426, 169);
            this.roundedTextBoxPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxPrice.Multiline = false;
            this.roundedTextBoxPrice.Name = "roundedTextBoxPrice";
            this.roundedTextBoxPrice.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxPrice.PasswordChar = false;
            this.roundedTextBoxPrice.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPrice.PlaceholderText = "";
            this.roundedTextBoxPrice.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxPrice.TabIndex = 7;
            this.roundedTextBoxPrice.Texts = "";
            this.roundedTextBoxPrice.UnderlinedStyle = false;
            // 
            // roundedTextBoxPass
            // 
            this.roundedTextBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPass.BorderRadius = 8;
            this.roundedTextBoxPass.BorderSize = 2;
            this.roundedTextBoxPass.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPass.Location = new System.Drawing.Point(39, 239);
            this.roundedTextBoxPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxPass.Multiline = false;
            this.roundedTextBoxPass.Name = "roundedTextBoxPass";
            this.roundedTextBoxPass.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxPass.PasswordChar = true;
            this.roundedTextBoxPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.PlaceholderText = "";
            this.roundedTextBoxPass.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxPass.TabIndex = 3;
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
            this.roundedTextBoxMail.Location = new System.Drawing.Point(39, 169);
            this.roundedTextBoxMail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxMail.Multiline = false;
            this.roundedTextBoxMail.Name = "roundedTextBoxMail";
            this.roundedTextBoxMail.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxMail.PasswordChar = false;
            this.roundedTextBoxMail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.PlaceholderText = "";
            this.roundedTextBoxMail.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxMail.TabIndex = 2;
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
            this.roundedTextBoxName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxName.Location = new System.Drawing.Point(39, 99);
            this.roundedTextBoxName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedTextBoxName.Multiline = false;
            this.roundedTextBoxName.Name = "roundedTextBoxName";
            this.roundedTextBoxName.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.roundedTextBoxName.PasswordChar = false;
            this.roundedTextBoxName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.PlaceholderText = "";
            this.roundedTextBoxName.Size = new System.Drawing.Size(320, 44);
            this.roundedTextBoxName.TabIndex = 1;
            this.roundedTextBoxName.Texts = "";
            this.roundedTextBoxName.UnderlinedStyle = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(252, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(328, 70);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Crear músico";
            // 
            // customComboBoxLang
            // 
            this.customComboBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxLang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxLang.BorderSize = 2;
            this.customComboBoxLang.DataSource = this.bindingSourceLang;
            this.customComboBoxLang.DisplayMember = "lang";
            this.customComboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxLang.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxLang.ForeColor = System.Drawing.Color.Black;
            this.customComboBoxLang.IconColor = System.Drawing.Color.Black;
            this.customComboBoxLang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxLang.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxLang.Location = new System.Drawing.Point(426, 96);
            this.customComboBoxLang.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxLang.Name = "customComboBoxLang";
            this.customComboBoxLang.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxLang.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxLang.TabIndex = 6;
            this.customComboBoxLang.Texts = "Idioma de canciones";
            this.customComboBoxLang.ValueMember = "id";
            // 
            // bindingSourceLang
            // 
            this.bindingSourceLang.DataSource = typeof(GigFinder.Models.Languages);
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
            this.roundedButtonCancel.Location = new System.Drawing.Point(596, 609);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 11;
            this.roundedButtonCancel.Text = "Cancelar";
            this.roundedButtonCancel.UseVisualStyleBackColor = false;
            this.roundedButtonCancel.Click += new System.EventHandler(this.roundedButtonCancel_Click);
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
            this.roundedButtonCreate.Location = new System.Drawing.Point(426, 609);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCreate.TabIndex = 10;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            this.roundedButtonCreate.Click += new System.EventHandler(this.roundedButtonCreate_Click);
            // 
            // CreateMusicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.customComboBoxLang);
            this.Controls.Add(this.labelGroupSize);
            this.Controls.Add(this.labelPrize);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGenres);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxGenres);
            this.Controls.Add(this.roundedTextBoxDescription);
            this.Controls.Add(this.roundedTextBoxConfirmPass);
            this.Controls.Add(this.roundedTextBoxSizeGroup);
            this.Controls.Add(this.roundedTextBoxPrice);
            this.Controls.Add(this.roundedTextBoxPass);
            this.Controls.Add(this.roundedTextBoxMail);
            this.Controls.Add(this.roundedTextBoxName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateMusicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateMusicianForm";
            this.Load += new System.EventHandler(this.CreateMusicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroupSize;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxGenres;
        private Controls.RoundedTextBox roundedTextBoxDescription;
        private Controls.RoundedTextBox roundedTextBoxConfirmPass;
        private Controls.RoundedTextBox roundedTextBoxSizeGroup;
        private Controls.RoundedTextBox roundedTextBoxPrice;
        private Controls.RoundedTextBox roundedTextBoxPass;
        private Controls.RoundedTextBox roundedTextBoxMail;
        private Controls.RoundedTextBox roundedTextBoxName;
        private System.Windows.Forms.Label labelTitle;
        private Controls.CustomComboBox customComboBoxLang;
        private Controls.RoundedButton roundedButtonCancel;
        private Controls.RoundedButton roundedButtonCreate;
        private System.Windows.Forms.BindingSource bindingSourceGenres;
        private System.Windows.Forms.BindingSource bindingSourceLang;
    }
}