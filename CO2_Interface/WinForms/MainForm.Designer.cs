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
            this.DataTreatmen_Button = new System.Windows.Forms.Button();
            this.COM_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.usersdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // DataTreatmen_Button
            // 
            this.DataTreatmen_Button.Location = new System.Drawing.Point(149, 490);
            this.DataTreatmen_Button.Margin = new System.Windows.Forms.Padding(2);
            this.DataTreatmen_Button.Name = "DataTreatmen_Button";
            this.DataTreatmen_Button.Size = new System.Drawing.Size(92, 41);
            this.DataTreatmen_Button.TabIndex = 1;
            this.DataTreatmen_Button.Text = "Data Treatment";
            this.DataTreatmen_Button.UseVisualStyleBackColor = true;
            this.DataTreatmen_Button.Click += new System.EventHandler(this.button_DataTreatment_Click);
            // 
            // COM_Button
            // 
            this.COM_Button.Location = new System.Drawing.Point(51, 490);
            this.COM_Button.Margin = new System.Windows.Forms.Padding(2);
            this.COM_Button.Name = "COM_Button";
            this.COM_Button.Size = new System.Drawing.Size(92, 41);
            this.COM_Button.TabIndex = 0;
            this.COM_Button.Text = "ConnectToPort";
            this.COM_Button.UseVisualStyleBackColor = true;
            this.COM_Button.Click += new System.EventHandler(this.button_COM_Click);
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
            this.MyContainer.Size = new System.Drawing.Size(862, 366);
            this.MyContainer.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 810);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.COM_Button);
            this.Controls.Add(this.DataTreatmen_Button);
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
        private System.Windows.Forms.Button DataTreatmen_Button;
        private System.Windows.Forms.Button COM_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
    }
}

