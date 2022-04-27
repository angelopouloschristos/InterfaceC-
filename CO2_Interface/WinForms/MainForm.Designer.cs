namespace CO2_Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ConnexionStatus_Label = new System.Windows.Forms.Label();
            this.Connexion_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_id = new System.Windows.Forms.ComboBox();
            this.lb_clock = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logo_helb = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.btn_change_minmax = new System.Windows.Forms.Button();
            this.max_value = new System.Windows.Forms.TextBox();
            this.min_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usersdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarm_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.ConfigFile_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(146, 65);
            this.ConnexionStatus_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(33, 13);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "Close";
            // 
            // Connexion_Label
            // 
            this.Connexion_Label.AutoSize = true;
            this.Connexion_Label.Location = new System.Drawing.Point(47, 65);
            this.Connexion_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Connexion_Label.Name = "Connexion_Label";
            this.Connexion_Label.Size = new System.Drawing.Size(96, 13);
            this.Connexion_Label.TabIndex = 3;
            this.Connexion_Label.Text = "Connexion Status: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(51, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 49);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(122, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 50);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.Location = new System.Drawing.Point(51, 81);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(753, 283);
            this.MyContainer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the ID";
            // 
            // combobox_id
            // 
            this.combobox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combobox_id.FormattingEnabled = true;
            this.combobox_id.Location = new System.Drawing.Point(908, 81);
            this.combobox_id.Name = "combobox_id";
            this.combobox_id.Size = new System.Drawing.Size(77, 21);
            this.combobox_id.Sorted = true;
            this.combobox_id.TabIndex = 9;
            // 
            // lb_clock
            // 
            this.lb_clock.AutoSize = true;
            this.lb_clock.Location = new System.Drawing.Point(676, 31);
            this.lb_clock.Name = "lb_clock";
            this.lb_clock.Size = new System.Drawing.Size(10, 13);
            this.lb_clock.TabIndex = 10;
            this.lb_clock.Text = ".";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "logo-helb.png");
            // 
            // logo_helb
            // 
            this.logo_helb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_helb.BackgroundImage")));
            this.logo_helb.Enabled = false;
            this.logo_helb.Location = new System.Drawing.Point(824, 214);
            this.logo_helb.Name = "logo_helb";
            this.logo_helb.Size = new System.Drawing.Size(161, 150);
            this.logo_helb.TabIndex = 11;
            this.logo_helb.UseVisualStyleBackColor = true;
            // 
            // account_button
            // 
            this.account_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("account_button.BackgroundImage")));
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Location = new System.Drawing.Point(258, 11);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(62, 50);
            this.account_button.TabIndex = 12;
            this.account_button.UseVisualStyleBackColor = true;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // btn_change_minmax
            // 
            this.btn_change_minmax.Location = new System.Drawing.Point(824, 181);
            this.btn_change_minmax.Name = "btn_change_minmax";
            this.btn_change_minmax.Size = new System.Drawing.Size(161, 30);
            this.btn_change_minmax.TabIndex = 13;
            this.btn_change_minmax.Text = "Change min and max";
            this.btn_change_minmax.UseVisualStyleBackColor = true;
            this.btn_change_minmax.Click += new System.EventHandler(this.btn_change_minmax_Click);
            // 
            // max_value
            // 
            this.max_value.Location = new System.Drawing.Point(853, 122);
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(132, 20);
            this.max_value.TabIndex = 14;
            // 
            // min_value
            // 
            this.min_value.Location = new System.Drawing.Point(853, 155);
            this.min_value.Name = "min_value";
            this.min_value.Size = new System.Drawing.Size(132, 20);
            this.min_value.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "min";
            // 
            // alarm_button
            // 
            this.alarm_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alarm_button.BackgroundImage")));
            this.alarm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alarm_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alarm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarm_button.Location = new System.Drawing.Point(190, 12);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Size = new System.Drawing.Size(62, 50);
            this.alarm_button.TabIndex = 18;
            this.alarm_button.UseVisualStyleBackColor = true;
            this.alarm_button.Click += new System.EventHandler(this.alarm_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Fuchsia;
            this.save_button.Location = new System.Drawing.Point(824, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(161, 41);
            this.save_button.TabIndex = 19;
            this.save_button.Text = "Save data";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // ConfigFile_Status
            // 
            this.ConfigFile_Status.AutoSize = true;
            this.ConfigFile_Status.Location = new System.Drawing.Point(824, 51);
            this.ConfigFile_Status.Name = "ConfigFile_Status";
            this.ConfigFile_Status.Size = new System.Drawing.Size(35, 13);
            this.ConfigFile_Status.TabIndex = 20;
            this.ConfigFile_Status.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 403);
            this.Controls.Add(this.ConfigFile_Status);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.alarm_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.min_value);
            this.Controls.Add(this.max_value);
            this.Controls.Add(this.btn_change_minmax);
            this.Controls.Add(this.account_button);
            this.Controls.Add(this.logo_helb);
            this.Controls.Add(this.lb_clock);
            this.Controls.Add(this.combobox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.BindingSource usersdataBindingSource;
        private System.Windows.Forms.Label ConnexionStatus_Label;
        private System.Windows.Forms.Label Connexion_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combobox_id;
        private System.Windows.Forms.Label lb_clock;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button logo_helb;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button btn_change_minmax;
        private System.Windows.Forms.TextBox max_value;
        private System.Windows.Forms.TextBox min_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button alarm_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label ConfigFile_Status;
    }
}

