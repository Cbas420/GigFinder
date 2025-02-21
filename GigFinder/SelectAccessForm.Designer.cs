namespace GigFinder
{
    partial class SelectAccessForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manageDatabaseButton = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.manageDatabaseButton);
            this.groupBox1.Controls.Add(this.manageUsersButton);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // manageDatabaseButton
            // 
            this.manageDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDatabaseButton.Location = new System.Drawing.Point(117, 152);
            this.manageDatabaseButton.Name = "manageDatabaseButton";
            this.manageDatabaseButton.Size = new System.Drawing.Size(341, 49);
            this.manageDatabaseButton.TabIndex = 7;
            this.manageDatabaseButton.Text = "Administrar base de datos";
            this.manageDatabaseButton.UseVisualStyleBackColor = true;
            this.manageDatabaseButton.Click += new System.EventHandler(this.buttonManageDatabase_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersButton.Location = new System.Drawing.Point(149, 48);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(273, 49);
            this.manageUsersButton.TabIndex = 6;
            this.manageUsersButton.Text = "Administrar usuarios";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(191, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 29);
            this.loginLabel.TabIndex = 0;
            // 
            // SelectAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectAccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAccessForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button manageDatabaseButton;
    }
}