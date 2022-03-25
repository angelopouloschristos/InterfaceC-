namespace CO2_Interface.Controls
{
    partial class MainControl
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
            this.ObjectsGrid1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectsGrid1
            // 
            this.ObjectsGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ObjectsGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsGrid1.Location = new System.Drawing.Point(0, 2);
            this.ObjectsGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.ObjectsGrid1.Name = "ObjectsGrid1";
            this.ObjectsGrid1.RowHeadersVisible = false;
            this.ObjectsGrid1.RowHeadersWidth = 51;
            this.ObjectsGrid1.RowTemplate.Height = 24;
            this.ObjectsGrid1.Size = new System.Drawing.Size(769, 271);
            this.ObjectsGrid1.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ObjectsGrid1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(816, 285);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView ObjectsGrid1;
    }
}
