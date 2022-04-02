namespace CO2_Interface.Controls
{
    partial class AlarmControl
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
            this.alarm_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // alarm_grid_view
            // 
            this.alarm_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alarm_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alarm_grid_view.Location = new System.Drawing.Point(0, 0);
            this.alarm_grid_view.Name = "alarm_grid_view";
            this.alarm_grid_view.ReadOnly = true;
            this.alarm_grid_view.RowHeadersVisible = false;
            this.alarm_grid_view.Size = new System.Drawing.Size(769, 271);
            this.alarm_grid_view.TabIndex = 4;
            // 
            // AlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alarm_grid_view);
            this.Name = "AlarmControl";
            this.Size = new System.Drawing.Size(816, 285);
            ((System.ComponentModel.ISupportInitialize)(this.alarm_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alarm_grid_view;
    }
}
