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
            this.alarm_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.layout_left = new System.Windows.Forms.FlowLayoutPanel();
            this.login_container = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.combo_box_com = new System.Windows.Forms.ToolStripComboBox();
            this.connect_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.strip_button_settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usersdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.criticalMinValue = new System.Windows.Forms.TextBox();
            this.criticalMaxValue = new System.Windows.Forms.TextBox();
            this.ConfigFile_Status = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.warningMinValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.warningMaxValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxPeriodValue = new System.Windows.Forms.TextBox();
            this.layout_left.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdataBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(10, 35);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(191, 29);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "No port selected";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Graphs";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.Location = new System.Drawing.Point(297, 74);
            this.MyContainer.Margin = new System.Windows.Forms.Padding(4);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(1001, 348);
            this.MyContainer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the ID";
            // 
            // combobox_id
            // 
            this.combobox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combobox_id.FormattingEnabled = true;
            this.combobox_id.Location = new System.Drawing.Point(104, 4);
            this.combobox_id.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_id.Name = "combobox_id";
            this.combobox_id.Size = new System.Drawing.Size(101, 24);
            this.combobox_id.Sorted = true;
            this.combobox_id.TabIndex = 9;
            // 
            // lb_clock
            // 
            this.lb_clock.AutoSize = true;
            this.lb_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clock.Location = new System.Drawing.Point(11, 6);
            this.lb_clock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_clock.Name = "lb_clock";
            this.lb_clock.Size = new System.Drawing.Size(129, 29);
            this.lb_clock.TabIndex = 10;
            this.lb_clock.Text = "Clock here";
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
            this.logo_helb.Location = new System.Drawing.Point(1061, 449);
            this.logo_helb.Margin = new System.Windows.Forms.Padding(4);
            this.logo_helb.Name = "logo_helb";
            this.logo_helb.Size = new System.Drawing.Size(161, 156);
            this.logo_helb.TabIndex = 11;
            this.logo_helb.UseVisualStyleBackColor = true;
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.Lavender;
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_button.Location = new System.Drawing.Point(4, 469);
            this.account_button.Margin = new System.Windows.Forms.Padding(4);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(280, 62);
            this.account_button.TabIndex = 12;
            this.account_button.Text = "Accounts";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // btn_change_minmax
            // 
            this.btn_change_minmax.Location = new System.Drawing.Point(1351, 543);
            this.btn_change_minmax.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change_minmax.Name = "btn_change_minmax";
            this.btn_change_minmax.Size = new System.Drawing.Size(215, 37);
            this.btn_change_minmax.TabIndex = 13;
            this.btn_change_minmax.Text = "Change min and max";
            this.btn_change_minmax.UseVisualStyleBackColor = true;
            this.btn_change_minmax.Click += new System.EventHandler(this.btn_change_minmax_Click);
            // 
            // max_value
            // 
            this.max_value.Location = new System.Drawing.Point(64, 76);
            this.max_value.Margin = new System.Windows.Forms.Padding(4);
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(127, 22);
            this.max_value.TabIndex = 14;
            // 
            // min_value
            // 
            this.min_value.Location = new System.Drawing.Point(60, 40);
            this.min_value.Margin = new System.Windows.Forms.Padding(4);
            this.min_value.Name = "min_value";
            this.min_value.Size = new System.Drawing.Size(127, 22);
            this.min_value.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(52, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(48, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "min";
            // 
            // alarm_button
            // 
            this.alarm_button.BackColor = System.Drawing.Color.Lavender;
            this.alarm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alarm_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alarm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_button.Location = new System.Drawing.Point(4, 399);
            this.alarm_button.Margin = new System.Windows.Forms.Padding(4);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Size = new System.Drawing.Size(280, 62);
            this.alarm_button.TabIndex = 18;
            this.alarm_button.Text = "Alarms";
            this.alarm_button.UseVisualStyleBackColor = false;
            this.alarm_button.Click += new System.EventHandler(this.alarm_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Thistle;
            this.save_button.Location = new System.Drawing.Point(1348, 74);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(215, 50);
            this.save_button.TabIndex = 19;
            this.save_button.Text = "Save data";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(11, 64);
            this.lb_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(262, 29);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "Sending status: nothing";
            // 
            // layout_left
            // 
            this.layout_left.BackColor = System.Drawing.Color.DarkBlue;
            this.layout_left.Controls.Add(this.login_container);
            this.layout_left.Controls.Add(this.button1);
            this.layout_left.Controls.Add(this.button2);
            this.layout_left.Controls.Add(this.alarm_button);
            this.layout_left.Controls.Add(this.account_button);
            this.layout_left.Location = new System.Drawing.Point(3, 74);
            this.layout_left.Margin = new System.Windows.Forms.Padding(4);
            this.layout_left.Name = "layout_left";
            this.layout_left.Size = new System.Drawing.Size(287, 542);
            this.layout_left.TabIndex = 22;
            // 
            // login_container
            // 
            this.login_container.Location = new System.Drawing.Point(4, 4);
            this.login_container.Margin = new System.Windows.Forms.Padding(4);
            this.login_container.Name = "login_container";
            this.login_container.Size = new System.Drawing.Size(280, 247);
            this.login_container.TabIndex = 27;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.combo_box_com,
            this.connect_button,
            this.toolStripSeparator2,
            this.strip_button_settings,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1579, 57);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // combo_box_com
            // 
            this.combo_box_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_com.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.combo_box_com.Name = "combo_box_com";
            this.combo_box_com.Size = new System.Drawing.Size(160, 57);
            // 
            // connect_button
            // 
            this.connect_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connect_button.Image = ((System.Drawing.Image)(resources.GetObject("connect_button.Image")));
            this.connect_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(104, 54);
            this.connect_button.Text = "Connect";
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // strip_button_settings
            // 
            this.strip_button_settings.AutoSize = false;
            this.strip_button_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strip_button_settings.Image = ((System.Drawing.Image)(resources.GetObject("strip_button_settings.Image")));
            this.strip_button_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_button_settings.Name = "strip_button_settings";
            this.strip_button_settings.Size = new System.Drawing.Size(100, 50);
            this.strip_button_settings.Text = "Settings";
            this.strip_button_settings.Click += new System.EventHandler(this.strip_button_settings_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.flowLayoutPanel1.Controls.Add(this.lb_clock);
            this.flowLayoutPanel1.Controls.Add(this.ConnexionStatus_Label);
            this.flowLayoutPanel1.Controls.Add(this.lb_status);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(297, 430);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 123);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Size = new System.Drawing.Size(68, 42);
            this.label4.TabIndex = 29;
            this.label4.Text = "critical \r\nmin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Size = new System.Drawing.Size(68, 42);
            this.label5.TabIndex = 28;
            this.label5.Text = "critical \r\nmax";
            // 
            // criticalMinValue
            // 
            this.criticalMinValue.Location = new System.Drawing.Point(80, 118);
            this.criticalMinValue.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.criticalMinValue.Name = "criticalMinValue";
            this.criticalMinValue.Size = new System.Drawing.Size(127, 22);
            this.criticalMinValue.TabIndex = 27;
            // 
            // criticalMaxValue
            // 
            this.criticalMaxValue.Location = new System.Drawing.Point(80, 160);
            this.criticalMaxValue.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.criticalMaxValue.Name = "criticalMaxValue";
            this.criticalMaxValue.Size = new System.Drawing.Size(127, 22);
            this.criticalMaxValue.TabIndex = 26;
            // 
            // ConfigFile_Status
            // 
            this.ConfigFile_Status.AutoSize = true;
            this.ConfigFile_Status.Location = new System.Drawing.Point(1321, 136);
            this.ConfigFile_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfigFile_Status.Name = "ConfigFile_Status";
            this.ConfigFile_Status.Size = new System.Drawing.Size(44, 16);
            this.ConfigFile_Status.TabIndex = 20;
            this.ConfigFile_Status.Text = "label4";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.combobox_id);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.min_value);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.max_value);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.criticalMinValue);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.criticalMaxValue);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.warningMinValue);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.warningMaxValue);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.maxPeriodValue);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1324, 155);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 339);
            this.flowLayoutPanel2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.label6.Size = new System.Drawing.Size(68, 42);
            this.label6.TabIndex = 33;
            this.label6.Text = "warning\r\nmin";
            // 
            // warningMinValue
            // 
            this.warningMinValue.Location = new System.Drawing.Point(80, 202);
            this.warningMinValue.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.warningMinValue.Name = "warningMinValue";
            this.warningMinValue.Size = new System.Drawing.Size(127, 22);
            this.warningMinValue.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.label7.Size = new System.Drawing.Size(68, 42);
            this.label7.TabIndex = 32;
            this.label7.Text = "warning\r\nmax";
            // 
            // warningMaxValue
            // 
            this.warningMaxValue.Location = new System.Drawing.Point(80, 244);
            this.warningMaxValue.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.warningMaxValue.Name = "warningMaxValue";
            this.warningMaxValue.Size = new System.Drawing.Size(127, 22);
            this.warningMaxValue.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.label8.Size = new System.Drawing.Size(61, 42);
            this.label8.TabIndex = 35;
            this.label8.Text = "max\r\nperiod";
            // 
            // maxPeriodValue
            // 
            this.maxPeriodValue.Location = new System.Drawing.Point(73, 286);
            this.maxPeriodValue.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.maxPeriodValue.Name = "maxPeriodValue";
            this.maxPeriodValue.Size = new System.Drawing.Size(127, 22);
            this.maxPeriodValue.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1579, 623);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.layout_left);
            this.Controls.Add(this.ConfigFile_Status);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.btn_change_minmax);
            this.Controls.Add(this.logo_helb);
            this.Controls.Add(this.MyContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Interface HELB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.layout_left.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdataBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.BindingSource usersdataBindingSource;
        private System.Windows.Forms.Label ConnexionStatus_Label;
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
        private System.Windows.Forms.Label lb_status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel layout_left;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox combo_box_com;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton strip_button_settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton connect_button;
        private System.Windows.Forms.FlowLayoutPanel login_container;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox criticalMinValue;
        private System.Windows.Forms.TextBox criticalMaxValue;
        private System.Windows.Forms.Label ConfigFile_Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox warningMinValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox warningMaxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxPeriodValue;
    }
}

