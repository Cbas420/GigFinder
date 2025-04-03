namespace GigFinder
{
    partial class ActivityRegisterForm
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
            this.customPanel1 = new GigFinder.Controls.CustomPanel();
            this.dataGridViewRegister = new System.Windows.Forms.DataGridView();
            this.actionmadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datelogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitylogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roundedButtonDelete = new GigFinder.Controls.RoundedButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitylogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.customPanel1.BorderRadius = 8;
            this.customPanel1.Controls.Add(this.dataGridViewRegister);
            this.customPanel1.Location = new System.Drawing.Point(20, 124);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 8);
            this.customPanel1.Size = new System.Drawing.Size(1148, 510);
            this.customPanel1.TabIndex = 24;
            // 
            // dataGridViewRegister
            // 
            this.dataGridViewRegister.AllowUserToAddRows = false;
            this.dataGridViewRegister.AllowUserToDeleteRows = false;
            this.dataGridViewRegister.AllowUserToResizeRows = false;
            this.dataGridViewRegister.AutoGenerateColumns = false;
            this.dataGridViewRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRegister.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRegister.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Passion One", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegister.ColumnHeadersHeight = 35;
            this.dataGridViewRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionmadeDataGridViewTextBoxColumn,
            this.datelogDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn});
            this.dataGridViewRegister.DataSource = this.activitylogBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegister.EnableHeadersVisualStyles = false;
            this.dataGridViewRegister.GridColor = System.Drawing.Color.White;
            this.dataGridViewRegister.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewRegister.MultiSelect = false;
            this.dataGridViewRegister.Name = "dataGridViewRegister";
            this.dataGridViewRegister.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegister.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRegister.RowHeadersVisible = false;
            this.dataGridViewRegister.RowTemplate.Height = 25;
            this.dataGridViewRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegister.Size = new System.Drawing.Size(1136, 502);
            this.dataGridViewRegister.TabIndex = 0;
            // 
            // actionmadeDataGridViewTextBoxColumn
            // 
            this.actionmadeDataGridViewTextBoxColumn.DataPropertyName = "action_made";
            this.actionmadeDataGridViewTextBoxColumn.HeaderText = "action_made";
            this.actionmadeDataGridViewTextBoxColumn.Name = "actionmadeDataGridViewTextBoxColumn";
            this.actionmadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datelogDataGridViewTextBoxColumn
            // 
            this.datelogDataGridViewTextBoxColumn.DataPropertyName = "date_log";
            this.datelogDataGridViewTextBoxColumn.HeaderText = "date_log";
            this.datelogDataGridViewTextBoxColumn.Name = "datelogDataGridViewTextBoxColumn";
            this.datelogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            this.adminidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activitylogBindingSource
            // 
            this.activitylogBindingSource.DataSource = typeof(GigFinder.Models.Activity_log);
            // 
            // roundedButtonDelete
            // 
            this.roundedButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundedButtonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonDelete.BorderRadius = 8;
            this.roundedButtonDelete.BorderSize = 0;
            this.roundedButtonDelete.FlatAppearance.BorderSize = 0;
            this.roundedButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDelete.Font = new System.Drawing.Font("Passion One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonDelete.ForeColor = System.Drawing.Color.White;
            this.roundedButtonDelete.Location = new System.Drawing.Point(1019, 121);
            this.roundedButtonDelete.Name = "roundedButtonDelete";
            this.roundedButtonDelete.Size = new System.Drawing.Size(0, 0);
            this.roundedButtonDelete.TabIndex = 21;
            this.roundedButtonDelete.Text = "Eliminar";
            this.roundedButtonDelete.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Passion One", 50F);
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(555, 74);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Registro de actividad";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::GigFinder.Properties.Resources.logo1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1094, 9);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 90);
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ActivityRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.roundedButtonDelete);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActivityRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityRegisterForm";
            this.Load += new System.EventHandler(this.ActivityRegisterForm_Load);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitylogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dataGridViewRegister;
        private Controls.RoundedButton roundedButtonDelete;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionmadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datelogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activitylogBindingSource;
    }
}