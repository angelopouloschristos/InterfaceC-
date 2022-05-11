namespace CO2_Interface.Controls
{
    partial class SettingsControl
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
            this.btn_save_sending_data = new System.Windows.Forms.Button();
            this.group_box_sending = new System.Windows.Forms.GroupBox();
            this.display_time_to_send = new System.Windows.Forms.Label();
            this.input_time_for_sending = new System.Windows.Forms.NumericUpDown();
            this.group_box_sending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_time_for_sending)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save_sending_data
            // 
            this.btn_save_sending_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_sending_data.Location = new System.Drawing.Point(30, 87);
            this.btn_save_sending_data.Name = "btn_save_sending_data";
            this.btn_save_sending_data.Size = new System.Drawing.Size(120, 40);
            this.btn_save_sending_data.TabIndex = 0;
            this.btn_save_sending_data.Text = "Save";
            this.btn_save_sending_data.UseVisualStyleBackColor = true;
            this.btn_save_sending_data.Click += new System.EventHandler(this.btn_save_sending_data_Click);
            // 
            // group_box_sending
            // 
            this.group_box_sending.Controls.Add(this.display_time_to_send);
            this.group_box_sending.Controls.Add(this.input_time_for_sending);
            this.group_box_sending.Controls.Add(this.btn_save_sending_data);
            this.group_box_sending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_box_sending.Location = new System.Drawing.Point(3, 3);
            this.group_box_sending.Name = "group_box_sending";
            this.group_box_sending.Size = new System.Drawing.Size(200, 144);
            this.group_box_sending.TabIndex = 1;
            this.group_box_sending.TabStop = false;
            this.group_box_sending.Text = "Sending Data";
            // 
            // display_time_to_send
            // 
            this.display_time_to_send.AutoSize = true;
            this.display_time_to_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_time_to_send.Location = new System.Drawing.Point(27, 25);
            this.display_time_to_send.Name = "display_time_to_send";
            this.display_time_to_send.Size = new System.Drawing.Size(33, 13);
            this.display_time_to_send.TabIndex = 2;
            this.display_time_to_send.Text = "error";
            // 
            // input_time_for_sending
            // 
            this.input_time_for_sending.Location = new System.Drawing.Point(30, 50);
            this.input_time_for_sending.Name = "input_time_for_sending";
            this.input_time_for_sending.Size = new System.Drawing.Size(120, 20);
            this.input_time_for_sending.TabIndex = 2;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.group_box_sending);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(816, 285);
            this.group_box_sending.ResumeLayout(false);
            this.group_box_sending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_time_for_sending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save_sending_data;
        private System.Windows.Forms.GroupBox group_box_sending;
        private System.Windows.Forms.NumericUpDown input_time_for_sending;
        private System.Windows.Forms.Label display_time_to_send;
    }
}
