namespace GigFinder
{
    partial class ManageIncidencesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.roundedButtonResolve = new GigFinder.Controls.RoundedButton();
            this.customPanel1 = new GigFinder.Controls.CustomPanel();
            this.dataGridViewIncidencies = new System.Windows.Forms.DataGridView();
            this.bindingSourceIncidencies = new System.Windows.Forms.BindingSource(this.components);
            this.customComboBoxOrder = new GigFinder.Controls.CustomComboBox();
            this.customComboBoxFilter = new GigFinder.Controls.CustomComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIncidencies)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 50F);
            this.labelTitle.Location = new System.Drawing.Point(7, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(579, 74);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Gestión de incidencias";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::GigFinder.Properties.Resources.logo1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1093, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 90);
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // roundedButtonResolve
            // 
            this.roundedButtonResolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonResolve.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonResolve.BorderRadius = 8;
            this.roundedButtonResolve.BorderSize = 0;
            this.roundedButtonResolve.FlatAppearance.BorderSize = 0;
            this.roundedButtonResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonResolve.Font = new System.Drawing.Font("Passion One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonResolve.ForeColor = System.Drawing.Color.White;
            this.roundedButtonResolve.Location = new System.Drawing.Point(1018, 124);
            this.roundedButtonResolve.Name = "roundedButtonResolve";
            this.roundedButtonResolve.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonResolve.TabIndex = 23;
            this.roundedButtonResolve.Text = "Resolver";
            this.roundedButtonResolve.UseVisualStyleBackColor = false;
            this.roundedButtonResolve.Click += new System.EventHandler(this.roundedButtonResolve_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.customPanel1.BorderRadius = 8;
            this.customPanel1.Controls.Add(this.dataGridViewIncidencies);
            this.customPanel1.Location = new System.Drawing.Point(20, 182);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 8);
            this.customPanel1.Size = new System.Drawing.Size(1148, 454);
            this.customPanel1.TabIndex = 22;
            // 
            // dataGridViewIncidencies
            // 
            this.dataGridViewIncidencies.AllowUserToAddRows = false;
            this.dataGridViewIncidencies.AllowUserToDeleteRows = false;
            this.dataGridViewIncidencies.AllowUserToResizeRows = false;
            this.dataGridViewIncidencies.AutoGenerateColumns = false;
            this.dataGridViewIncidencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncidencies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIncidencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIncidencies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewIncidencies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Passion One", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIncidencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIncidencies.ColumnHeadersHeight = 35;
            this.dataGridViewIncidencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewIncidencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.adminnoteDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn});
            this.dataGridViewIncidencies.DataSource = this.bindingSourceIncidencies;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIncidencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIncidencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncidencies.EnableHeadersVisualStyles = false;
            this.dataGridViewIncidencies.GridColor = System.Drawing.Color.White;
            this.dataGridViewIncidencies.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewIncidencies.MultiSelect = false;
            this.dataGridViewIncidencies.Name = "dataGridViewIncidencies";
            this.dataGridViewIncidencies.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIncidencies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIncidencies.RowHeadersVisible = false;
            this.dataGridViewIncidencies.RowTemplate.Height = 25;
            this.dataGridViewIncidencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIncidencies.Size = new System.Drawing.Size(1136, 446);
            this.dataGridViewIncidencies.TabIndex = 0;
            // 
            // bindingSourceIncidencies
            // 
            this.bindingSourceIncidencies.DataSource = typeof(GigFinder.Models.Incidences);
            // 
            // customComboBoxOrder
            // 
            this.customComboBoxOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxOrder.BorderSize = 1;
            this.customComboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxOrder.Font = new System.Drawing.Font("Passion One", 14F);
            this.customComboBoxOrder.ForeColor = System.Drawing.Color.White;
            this.customComboBoxOrder.IconColor = System.Drawing.Color.White;
            this.customComboBoxOrder.Items.AddRange(new object[] {
            "Status",
            "User_id",
            "Admin_id"});
            this.customComboBoxOrder.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxOrder.ListTextColor = System.Drawing.Color.White;
            this.customComboBoxOrder.Location = new System.Drawing.Point(195, 124);
            this.customComboBoxOrder.MinimumSize = new System.Drawing.Size(100, 30);
            this.customComboBoxOrder.Name = "customComboBoxOrder";
            this.customComboBoxOrder.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBoxOrder.Size = new System.Drawing.Size(150, 41);
            this.customComboBoxOrder.TabIndex = 21;
            this.customComboBoxOrder.Texts = "Ordenar por";
            this.customComboBoxOrder.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxOrder_OnSelectedIndexChanged);
            // 
            // customComboBoxFilter
            // 
            this.customComboBoxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxFilter.BorderSize = 1;
            this.customComboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxFilter.Font = new System.Drawing.Font("Passion One", 14F);
            this.customComboBoxFilter.ForeColor = System.Drawing.Color.White;
            this.customComboBoxFilter.IconColor = System.Drawing.Color.White;
            this.customComboBoxFilter.Items.AddRange(new object[] {
            "All",
            "Pendent",
            "Ignores",
            "Fixed"});
            this.customComboBoxFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.customComboBoxFilter.ListTextColor = System.Drawing.Color.White;
            this.customComboBoxFilter.Location = new System.Drawing.Point(26, 123);
            this.customComboBoxFilter.MinimumSize = new System.Drawing.Size(100, 30);
            this.customComboBoxFilter.Name = "customComboBoxFilter";
            this.customComboBoxFilter.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBoxFilter.Size = new System.Drawing.Size(150, 41);
            this.customComboBoxFilter.TabIndex = 24;
            this.customComboBoxFilter.Texts = "Filtrar por";
            this.customComboBoxFilter.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxFilter_OnSelectedIndexChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminnoteDataGridViewTextBoxColumn
            // 
            this.adminnoteDataGridViewTextBoxColumn.DataPropertyName = "admin_note";
            this.adminnoteDataGridViewTextBoxColumn.HeaderText = "Admin note";
            this.adminnoteDataGridViewTextBoxColumn.Name = "adminnoteDataGridViewTextBoxColumn";
            this.adminnoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "Admin id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            this.adminidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageIncidencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customComboBoxFilter);
            this.Controls.Add(this.roundedButtonResolve);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customComboBoxOrder);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageIncidencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageIncidences";
            this.Load += new System.EventHandler(this.ManageIncidencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIncidencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dataGridViewIncidencies;
        private Controls.CustomComboBox customComboBoxOrder;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.BindingSource bindingSourceIncidencies;
        private Controls.RoundedButton roundedButtonResolve;
        private Controls.CustomComboBox customComboBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
    }
}