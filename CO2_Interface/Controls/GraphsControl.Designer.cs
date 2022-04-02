namespace CO2_Interface.Controls
{
    partial class GraphsControl
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_time = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(3, 3);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(727, 235);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "MyChart";
            // 
            // comboBox_time
            // 
            this.comboBox_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_time.FormattingEnabled = true;
            this.comboBox_time.Location = new System.Drawing.Point(623, 147);
            this.comboBox_time.Name = "comboBox_time";
            this.comboBox_time.Size = new System.Drawing.Size(85, 21);
            this.comboBox_time.TabIndex = 1;
            this.comboBox_time.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // GraphsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_time);
            this.Controls.Add(this.Chart);
            this.Name = "GraphsControl";
            this.Size = new System.Drawing.Size(743, 257);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_time;
    }
}
