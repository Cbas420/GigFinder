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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.userColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterUserPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.actionsToolStrip.SuspendLayout();
            this.databaseManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.filterUserPanel.SuspendLayout();
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
            this.databaseManagementPanel.Controls.Add(this.saveButton);
            this.databaseManagementPanel.Controls.Add(this.usersDataGridView);
            this.databaseManagementPanel.Location = new System.Drawing.Point(14, 188);
            this.databaseManagementPanel.Name = "databaseManagementPanel";
            this.databaseManagementPanel.Size = new System.Drawing.Size(616, 224);
            this.databaseManagementPanel.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(37, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 30);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userColumn,
            this.roleColumn,
            this.lastLoginColumn,
            this.creationDateColumn});
            this.usersDataGridView.Location = new System.Drawing.Point(37, 20);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(543, 150);
            this.usersDataGridView.TabIndex = 16;
            // 
            // userColumn
            // 
            this.userColumn.HeaderText = "Usuario";
            this.userColumn.Name = "userColumn";
            this.userColumn.Width = 125;
            // 
            // roleColumn
            // 
            this.roleColumn.HeaderText = "Rol";
            this.roleColumn.Name = "roleColumn";
            this.roleColumn.Width = 125;
            // 
            // lastLoginColumn
            // 
            this.lastLoginColumn.HeaderText = "Última sesión";
            this.lastLoginColumn.Name = "lastLoginColumn";
            this.lastLoginColumn.Width = 125;
            // 
            // creationDateColumn
            // 
            this.creationDateColumn.HeaderText = "fecha de creacion";
            this.creationDateColumn.Name = "creationDateColumn";
            this.creationDateColumn.Width = 125;
            // 
            // filterUserPanel
            // 
            this.filterUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterUserPanel.Controls.Add(this.button1);
            this.filterUserPanel.Controls.Add(this.label2);
            this.filterUserPanel.Controls.Add(this.comboBox1);
            this.filterUserPanel.Controls.Add(this.label1);
            this.filterUserPanel.Location = new System.Drawing.Point(14, 37);
            this.filterUserPanel.Name = "filterUserPanel";
            this.filterUserPanel.Size = new System.Drawing.Size(613, 140);
            this.filterUserPanel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Database Management";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 18;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(181, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 424);
            this.Controls.Add(this.databaseManagementPanel);
            this.Controls.Add(this.filterUserPanel);
            this.Controls.Add(this.actionsToolStrip);
            this.Name = "ManageDatabaseForm";
            this.Text = "ManageDatabaseForm";
            this.actionsToolStrip.ResumeLayout(false);
            this.actionsToolStrip.PerformLayout();
            this.databaseManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.filterUserPanel.ResumeLayout(false);
            this.filterUserPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateColumn;
        private System.Windows.Forms.Panel filterUserPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}