namespace CO2_Interface.Controls
{
    partial class ConfigControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigControl));
            this.ConfigFile_Status = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min_value = new System.Windows.Forms.TextBox();
            this.max_value = new System.Windows.Forms.TextBox();
            this.btn_change_minmax = new System.Windows.Forms.Button();
            this.logo_helb = new System.Windows.Forms.Button();
            this.combobox_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfigFile_Status
            // 
            this.ConfigFile_Status.AutoSize = true;
            this.ConfigFile_Status.Location = new System.Drawing.Point(6, 51);
            this.ConfigFile_Status.Name = "ConfigFile_Status";
            this.ConfigFile_Status.Size = new System.Drawing.Size(35, 13);
            this.ConfigFile_Status.TabIndex = 30;
            this.ConfigFile_Status.Text = "label4";
           // this.ConfigFile_Status.Click += new System.EventHandler(this.ConfigFile_Status_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Lavender;
            this.save_button.Location = new System.Drawing.Point(6, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(161, 41);
            this.save_button.TabIndex = 29;
            this.save_button.Text = "Save data";
            this.save_button.UseVisualStyleBackColor = false;
          //  this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "min";
          //  this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "max";
          //  this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // min_value
            // 
            this.min_value.Location = new System.Drawing.Point(35, 155);
            this.min_value.Name = "min_value";
            this.min_value.Size = new System.Drawing.Size(132, 20);
            this.min_value.TabIndex = 26;
          //  this.min_value.TextChanged += new System.EventHandler(this.min_value_TextChanged);
            // 
            // max_value
            // 
            this.max_value.Location = new System.Drawing.Point(35, 122);
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(132, 20);
            this.max_value.TabIndex = 25;
          //  this.max_value.TextChanged += new System.EventHandler(this.max_value_TextChanged);
            // 
            // btn_change_minmax
            // 
            this.btn_change_minmax.BackColor = System.Drawing.Color.Lavender;
            this.btn_change_minmax.Location = new System.Drawing.Point(6, 181);
            this.btn_change_minmax.Name = "btn_change_minmax";
            this.btn_change_minmax.Size = new System.Drawing.Size(161, 30);
            this.btn_change_minmax.TabIndex = 24;
            this.btn_change_minmax.Text = "Change min and max";
            this.btn_change_minmax.UseVisualStyleBackColor = false;
           // this.btn_change_minmax.Click += new System.EventHandler(this.btn_change_minmax_Click);
            // 
            // logo_helb
            // 
            this.logo_helb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_helb.BackgroundImage")));
            this.logo_helb.Enabled = false;
            this.logo_helb.Location = new System.Drawing.Point(6, 214);
            this.logo_helb.Name = "logo_helb";
            this.logo_helb.Size = new System.Drawing.Size(161, 150);
            this.logo_helb.TabIndex = 23;
            this.logo_helb.UseVisualStyleBackColor = true;
          //  this.logo_helb.Click += new System.EventHandler(this.logo_helb_Click);
            // 
            // combobox_id
            // 
            this.combobox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combobox_id.FormattingEnabled = true;
            this.combobox_id.Location = new System.Drawing.Point(90, 81);
            this.combobox_id.Name = "combobox_id";
            this.combobox_id.Size = new System.Drawing.Size(77, 21);
            this.combobox_id.Sorted = true;
            this.combobox_id.TabIndex = 22;
         //   this.combobox_id.SelectedIndexChanged += new System.EventHandler(this.combobox_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select the ID";
         //   this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.ConfigFile_Status);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.min_value);
            this.Controls.Add(this.max_value);
            this.Controls.Add(this.btn_change_minmax);
            this.Controls.Add(this.logo_helb);
            this.Controls.Add(this.combobox_id);
            this.Controls.Add(this.label1);
            this.Name = "ConfigControl";
            this.Size = new System.Drawing.Size(170, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfigFile_Status;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox min_value;
        private System.Windows.Forms.TextBox max_value;
        private System.Windows.Forms.Button btn_change_minmax;
        private System.Windows.Forms.Button logo_helb;
        public System.Windows.Forms.ComboBox combobox_id;
        private System.Windows.Forms.Label label1;
    }
}
