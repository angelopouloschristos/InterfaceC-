namespace CO2_Interface.Controls
{
    partial class ConfigAlarmControl
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
            this.btn_config_alarm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.criticalMinValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.criticalMaxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warningMinValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.warningMaxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_config_alarm
            // 
            this.btn_config_alarm.Location = new System.Drawing.Point(38, 203);
            this.btn_config_alarm.Name = "btn_config_alarm";
            this.btn_config_alarm.Size = new System.Drawing.Size(91, 32);
            this.btn_config_alarm.TabIndex = 0;
            this.btn_config_alarm.Text = "Config Alarm";
            this.btn_config_alarm.UseVisualStyleBackColor = true;
            this.btn_config_alarm.Click += new System.EventHandler(this.btn_config_alarm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 46;
            this.label4.Text = "critical \r\nmin";
            // 
            // criticalMinValue
            // 
            this.criticalMinValue.BackColor = System.Drawing.Color.Lavender;
            this.criticalMinValue.Location = new System.Drawing.Point(74, 24);
            this.criticalMinValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.criticalMinValue.Name = "criticalMinValue";
            this.criticalMinValue.Size = new System.Drawing.Size(85, 20);
            this.criticalMinValue.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.label5.Size = new System.Drawing.Size(65, 34);
            this.label5.TabIndex = 45;
            this.label5.Text = "critical \r\nmax";
            // 
            // criticalMaxValue
            // 
            this.criticalMaxValue.BackColor = System.Drawing.Color.Lavender;
            this.criticalMaxValue.Location = new System.Drawing.Point(74, 60);
            this.criticalMaxValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.criticalMaxValue.Name = "criticalMaxValue";
            this.criticalMaxValue.Size = new System.Drawing.Size(85, 20);
            this.criticalMaxValue.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label6.Size = new System.Drawing.Size(63, 34);
            this.label6.TabIndex = 48;
            this.label6.Text = "warning\r\nmin";
            // 
            // warningMinValue
            // 
            this.warningMinValue.BackColor = System.Drawing.Color.Lavender;
            this.warningMinValue.Location = new System.Drawing.Point(72, 96);
            this.warningMinValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.warningMinValue.Name = "warningMinValue";
            this.warningMinValue.Size = new System.Drawing.Size(87, 20);
            this.warningMinValue.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label7.Size = new System.Drawing.Size(63, 34);
            this.label7.TabIndex = 47;
            this.label7.Text = "warning\r\nmax";
            // 
            // warningMaxValue
            // 
            this.warningMaxValue.BackColor = System.Drawing.Color.Lavender;
            this.warningMaxValue.Location = new System.Drawing.Point(72, 132);
            this.warningMaxValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.warningMaxValue.Name = "warningMaxValue";
            this.warningMaxValue.Size = new System.Drawing.Size(87, 20);
            this.warningMaxValue.TabIndex = 42;
            // 
            // ConfigAlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.criticalMinValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.criticalMaxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warningMinValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warningMaxValue);
            this.Controls.Add(this.btn_config_alarm);
            this.Name = "ConfigAlarmControl";
            this.Size = new System.Drawing.Size(173, 275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_config_alarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox criticalMinValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox criticalMaxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox warningMinValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox warningMaxValue;
    }
}
