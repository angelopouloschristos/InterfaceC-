namespace CO2_Interface.Controls
{
    partial class ManagerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_grid_accounts = new System.Windows.Forms.DataGridView();
            this.data_grid_perm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_perm)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_accounts
            // 
            this.data_grid_accounts.AllowUserToAddRows = false;
            this.data_grid_accounts.AllowUserToDeleteRows = false;
            this.data_grid_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_accounts.Location = new System.Drawing.Point(0, 0);
            this.data_grid_accounts.Name = "data_grid_accounts";
            this.data_grid_accounts.ReadOnly = true;
            this.data_grid_accounts.Size = new System.Drawing.Size(760, 125);
            this.data_grid_accounts.TabIndex = 0;
            // 
            // data_grid_perm
            // 
            this.data_grid_perm.AllowUserToAddRows = false;
            this.data_grid_perm.AllowUserToDeleteRows = false;
            this.data_grid_perm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_perm.Location = new System.Drawing.Point(0, 152);
            this.data_grid_perm.Name = "data_grid_perm";
            this.data_grid_perm.ReadOnly = true;
            this.data_grid_perm.Size = new System.Drawing.Size(760, 125);
            this.data_grid_perm.TabIndex = 1;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_grid_perm);
            this.Controls.Add(this.data_grid_accounts);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(765, 280);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_perm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_accounts;
        private System.Windows.Forms.DataGridView data_grid_perm;
    }
}
