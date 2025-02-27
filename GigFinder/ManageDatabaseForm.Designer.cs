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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDatabaseForm));
            this.actionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.goBackButton = new System.Windows.Forms.ToolStripButton();
            this.signOutButton = new System.Windows.Forms.ToolStripButton();
            this.changesHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.databaseManagementPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataBaseDataGridView = new System.Windows.Forms.DataGridView();
            this.filterQueryPanel = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.queryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicianGenreIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicianSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicianSongLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicianPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicianLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCreationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageRatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.actionsToolStrip.SuspendLayout();
            this.databaseManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataGridView)).BeginInit();
            this.filterQueryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsToolStrip
            // 
            this.actionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackButton,
            this.signOutButton,
            this.changesHistoryButton});
            this.actionsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsToolStrip.Name = "actionsToolStrip";
            this.actionsToolStrip.Size = new System.Drawing.Size(644, 25);
            this.actionsToolStrip.TabIndex = 9;
            this.actionsToolStrip.Text = "toolStrip1";
            // 
            // goBackButton
            // 
            this.goBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.goBackButton.Image = ((System.Drawing.Image)(resources.GetObject("goBackButton.Image")));
            this.goBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(23, 22);
            this.goBackButton.Text = "toolStripButton1";
            this.goBackButton.ToolTipText = "Volver";
            // 
            // signOutButton
            // 
            this.signOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.signOutButton.Image = ((System.Drawing.Image)(resources.GetObject("signOutButton.Image")));
            this.signOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(23, 22);
            this.signOutButton.Text = "toolStripButton3";
            this.signOutButton.ToolTipText = "Cerrar Sesión";
            // 
            // changesHistoryButton
            // 
            this.changesHistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changesHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("changesHistoryButton.Image")));
            this.changesHistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changesHistoryButton.Name = "changesHistoryButton";
            this.changesHistoryButton.Size = new System.Drawing.Size(23, 22);
            this.changesHistoryButton.Text = "toolStripButton2";
            this.changesHistoryButton.ToolTipText = "Historial";
            // 
            // databaseManagementPanel
            // 
            this.databaseManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseManagementPanel.Controls.Add(this.button1);
            this.databaseManagementPanel.Controls.Add(this.saveButton);
            this.databaseManagementPanel.Controls.Add(this.dataBaseDataGridView);
            this.databaseManagementPanel.Location = new System.Drawing.Point(14, 188);
            this.databaseManagementPanel.Name = "databaseManagementPanel";
            this.databaseManagementPanel.Size = new System.Drawing.Size(616, 224);
            this.databaseManagementPanel.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(473, 176);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 30);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // dataBaseDataGridView
            // 
            this.dataBaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdColumn,
            this.companyCapacityColumn,
            this.musicianGenreIdColumn,
            this.musicianSizeColumn,
            this.musicianSongLanguageColumn,
            this.musicianPriceColumn,
            this.musicianLanguageColumn,
            this.userNameColumn,
            this.userEmailColumn,
            this.userDescriptionColumn,
            this.userRoleColumn,
            this.userCreationDateColumn,
            this.userPasswordColumn,
            this.userTypeColumn,
            this.averageRatingColumn});
            this.dataBaseDataGridView.Location = new System.Drawing.Point(37, 20);
            this.dataBaseDataGridView.Name = "dataBaseDataGridView";
            this.dataBaseDataGridView.RowHeadersVisible = false;
            this.dataBaseDataGridView.Size = new System.Drawing.Size(543, 150);
            this.dataBaseDataGridView.TabIndex = 16;
            // 
            // filterQueryPanel
            // 
            this.filterQueryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterQueryPanel.Controls.Add(this.label3);
            this.filterQueryPanel.Controls.Add(this.label1);
            this.filterQueryPanel.Controls.Add(this.filterButton);
            this.filterQueryPanel.Controls.Add(this.label2);
            this.filterQueryPanel.Controls.Add(this.queryTypeComboBox);
            this.filterQueryPanel.Controls.Add(this.databaseLabel);
            this.filterQueryPanel.Location = new System.Drawing.Point(14, 37);
            this.filterQueryPanel.Name = "filterQueryPanel";
            this.filterQueryPanel.Size = new System.Drawing.Size(613, 140);
            this.filterQueryPanel.TabIndex = 17;
            // 
            // filterButton
            // 
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Location = new System.Drawing.Point(87, 85);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(107, 30);
            this.filterButton.TabIndex = 20;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo";
            // 
            // queryTypeComboBox
            // 
            this.queryTypeComboBox.FormattingEnabled = true;
            this.queryTypeComboBox.Location = new System.Drawing.Point(87, 51);
            this.queryTypeComboBox.Name = "queryTypeComboBox";
            this.queryTypeComboBox.Size = new System.Drawing.Size(201, 21);
            this.queryTypeComboBox.TabIndex = 18;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.Location = new System.Drawing.Point(212, 9);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(196, 20);
            this.databaseLabel.TabIndex = 17;
            this.databaseLabel.Text = "Database Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "*SUPER GRAFICO*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "*SUPER RATING BIEN MAMALONES*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userIdColumn
            // 
            this.userIdColumn.HeaderText = "user id";
            this.userIdColumn.Name = "userIdColumn";
            this.userIdColumn.Width = 125;
            // 
            // companyCapacityColumn
            // 
            this.companyCapacityColumn.HeaderText = "company capacity";
            this.companyCapacityColumn.Name = "companyCapacityColumn";
            // 
            // musicianGenreIdColumn
            // 
            this.musicianGenreIdColumn.HeaderText = "musician genre id";
            this.musicianGenreIdColumn.Name = "musicianGenreIdColumn";
            // 
            // musicianSizeColumn
            // 
            this.musicianSizeColumn.HeaderText = "musician size";
            this.musicianSizeColumn.Name = "musicianSizeColumn";
            // 
            // musicianSongLanguageColumn
            // 
            this.musicianSongLanguageColumn.HeaderText = "musician song language";
            this.musicianSongLanguageColumn.Name = "musicianSongLanguageColumn";
            // 
            // musicianPriceColumn
            // 
            this.musicianPriceColumn.HeaderText = "musician price";
            this.musicianPriceColumn.Name = "musicianPriceColumn";
            // 
            // musicianLanguageColumn
            // 
            this.musicianLanguageColumn.HeaderText = "musician language";
            this.musicianLanguageColumn.Name = "musicianLanguageColumn";
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "user name";
            this.userNameColumn.Name = "userNameColumn";
            // 
            // userEmailColumn
            // 
            this.userEmailColumn.HeaderText = "user email";
            this.userEmailColumn.Name = "userEmailColumn";
            // 
            // userDescriptionColumn
            // 
            this.userDescriptionColumn.HeaderText = "user description";
            this.userDescriptionColumn.Name = "userDescriptionColumn";
            // 
            // userRoleColumn
            // 
            this.userRoleColumn.HeaderText = "user role";
            this.userRoleColumn.Name = "userRoleColumn";
            this.userRoleColumn.Width = 125;
            // 
            // userCreationDateColumn
            // 
            this.userCreationDateColumn.HeaderText = "user creation date";
            this.userCreationDateColumn.Name = "userCreationDateColumn";
            this.userCreationDateColumn.Width = 125;
            // 
            // userPasswordColumn
            // 
            this.userPasswordColumn.HeaderText = "user password";
            this.userPasswordColumn.Name = "userPasswordColumn";
            // 
            // userTypeColumn
            // 
            this.userTypeColumn.HeaderText = "user type";
            this.userTypeColumn.Name = "userTypeColumn";
            // 
            // averageRatingColumn
            // 
            this.averageRatingColumn.HeaderText = "user avg rating";
            this.averageRatingColumn.Name = "averageRatingColumn";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(37, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 424);
            this.Controls.Add(this.databaseManagementPanel);
            this.Controls.Add(this.filterQueryPanel);
            this.Controls.Add(this.actionsToolStrip);
            this.Name = "ManageDatabaseForm";
            this.Text = "ManageDatabaseForm";
            this.actionsToolStrip.ResumeLayout(false);
            this.actionsToolStrip.PerformLayout();
            this.databaseManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataGridView)).EndInit();
            this.filterQueryPanel.ResumeLayout(false);
            this.filterQueryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip actionsToolStrip;
        private System.Windows.Forms.ToolStripButton goBackButton;
        private System.Windows.Forms.ToolStripButton signOutButton;
        private System.Windows.Forms.ToolStripButton changesHistoryButton;
        private System.Windows.Forms.Panel databaseManagementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataBaseDataGridView;
        private System.Windows.Forms.Panel filterQueryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox queryTypeComboBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicianGenreIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicianSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicianSongLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicianPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicianLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCreationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageRatingColumn;
        private System.Windows.Forms.Button button1;
    }
}