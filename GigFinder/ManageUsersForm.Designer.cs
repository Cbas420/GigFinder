namespace GigFinder
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.actionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.goBackButton = new System.Windows.Forms.ToolStripButton();
            this.signOutButton = new System.Windows.Forms.ToolStripButton();
            this.changesHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.filterUserPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.superUserCheckbox = new System.Windows.Forms.CheckBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.databaseManagementPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.userColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceCheckBox = new System.Windows.Forms.CheckBox();
            this.actionsToolStrip.SuspendLayout();
            this.filterUserPanel.SuspendLayout();
            this.databaseManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
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
            this.actionsToolStrip.Size = new System.Drawing.Size(640, 25);
            this.actionsToolStrip.TabIndex = 8;
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
            this.goBackButton.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // filterUserPanel
            // 
            this.filterUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterUserPanel.Controls.Add(this.label1);
            this.filterUserPanel.Controls.Add(this.maintenanceCheckBox);
            this.filterUserPanel.Controls.Add(this.adminCheckBox);
            this.filterUserPanel.Controls.Add(this.userTextBox);
            this.filterUserPanel.Controls.Add(this.superUserCheckbox);
            this.filterUserPanel.Controls.Add(this.roleLabel);
            this.filterUserPanel.Controls.Add(this.searchButton);
            this.filterUserPanel.Controls.Add(this.userLabel);
            this.filterUserPanel.Location = new System.Drawing.Point(12, 44);
            this.filterUserPanel.Name = "filterUserPanel";
            this.filterUserPanel.Size = new System.Drawing.Size(613, 109);
            this.filterUserPanel.TabIndex = 8;
            this.filterUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filterUserPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Management";
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(214, 72);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(89, 17);
            this.adminCheckBox.TabIndex = 13;
            this.adminCheckBox.Text = "Administrador";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(122, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(275, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // superUserCheckbox
            // 
            this.superUserCheckbox.AutoSize = true;
            this.superUserCheckbox.Location = new System.Drawing.Point(122, 71);
            this.superUserCheckbox.Name = "superUserCheckbox";
            this.superUserCheckbox.Size = new System.Drawing.Size(93, 17);
            this.superUserCheckbox.TabIndex = 12;
            this.superUserCheckbox.Text = "Super-Usuario";
            this.superUserCheckbox.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(80, 68);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 20);
            this.roleLabel.TabIndex = 9;
            this.roleLabel.Text = "Rol";
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(418, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 30);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(49, 38);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(64, 20);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Usuario";
            // 
            // databaseManagementPanel
            // 
            this.databaseManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseManagementPanel.Controls.Add(this.saveButton);
            this.databaseManagementPanel.Controls.Add(this.createButton);
            this.databaseManagementPanel.Controls.Add(this.deleteButton);
            this.databaseManagementPanel.Controls.Add(this.usersDataGridView);
            this.databaseManagementPanel.Location = new System.Drawing.Point(12, 159);
            this.databaseManagementPanel.Name = "databaseManagementPanel";
            this.databaseManagementPanel.Size = new System.Drawing.Size(616, 253);
            this.databaseManagementPanel.TabIndex = 16;
            this.databaseManagementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.databaseManagementPanel_Paint);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(37, 211);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 30);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(37, 14);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(107, 30);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "Crear";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(150, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 30);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userColumn,
            this.roleColumn,
            this.lastLoginColumn,
            this.creationDateColumn});
            this.usersDataGridView.Location = new System.Drawing.Point(37, 50);
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
            // maintenanceCheckBox
            // 
            this.maintenanceCheckBox.AutoSize = true;
            this.maintenanceCheckBox.Location = new System.Drawing.Point(302, 72);
            this.maintenanceCheckBox.Name = "maintenanceCheckBox";
            this.maintenanceCheckBox.Size = new System.Drawing.Size(95, 17);
            this.maintenanceCheckBox.TabIndex = 14;
            this.maintenanceCheckBox.Text = "Mantenimiento";
            this.maintenanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 427);
            this.Controls.Add(this.databaseManagementPanel);
            this.Controls.Add(this.filterUserPanel);
            this.Controls.Add(this.actionsToolStrip);
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersForm";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.actionsToolStrip.ResumeLayout(false);
            this.actionsToolStrip.PerformLayout();
            this.filterUserPanel.ResumeLayout(false);
            this.filterUserPanel.PerformLayout();
            this.databaseManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip actionsToolStrip;
        private System.Windows.Forms.ToolStripButton goBackButton;
        private System.Windows.Forms.ToolStripButton signOutButton;
        private System.Windows.Forms.ToolStripButton changesHistoryButton;
        private System.Windows.Forms.Panel filterUserPanel;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.CheckBox superUserCheckbox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel databaseManagementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox maintenanceCheckBox;
    }
}