namespace CO2_Interface.Controls
{
    partial class AccountControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountControl));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.Button();
            this.login_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_input_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_input_password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.login_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 92);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "name here";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "last name here";
            // 
            // profile_picture
            // 
            this.profile_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_picture.BackgroundImage")));
            this.profile_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_picture.Location = new System.Drawing.Point(69, 18);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(60, 60);
            this.profile_picture.TabIndex = 3;
            this.profile_picture.UseVisualStyleBackColor = true;
            // 
            // login_layout
            // 
            this.login_layout.Controls.Add(this.label3);
            this.login_layout.Controls.Add(this.label2);
            this.login_layout.Controls.Add(this.tb_input_name);
            this.login_layout.Controls.Add(this.label1);
            this.login_layout.Controls.Add(this.tb_input_password);
            this.login_layout.Controls.Add(this.login_button);
            this.login_layout.Controls.Add(this.register_btn);
            this.login_layout.Location = new System.Drawing.Point(4, 4);
            this.login_layout.Name = "login_layout";
            this.login_layout.Size = new System.Drawing.Size(200, 181);
            this.login_layout.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login please";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tb_input_name
            // 
            this.tb_input_name.BackColor = System.Drawing.Color.Lavender;
            this.tb_input_name.Location = new System.Drawing.Point(65, 44);
            this.tb_input_name.Name = "tb_input_name";
            this.tb_input_name.Size = new System.Drawing.Size(122, 20);
            this.tb_input_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // tb_input_password
            // 
            this.tb_input_password.BackColor = System.Drawing.Color.Lavender;
            this.tb_input_password.Location = new System.Drawing.Point(70, 70);
            this.tb_input_password.Name = "tb_input_password";
            this.tb_input_password.Size = new System.Drawing.Size(122, 20);
            this.tb_input_password.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Lavender;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.login_button.Location = new System.Drawing.Point(3, 96);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(197, 43);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Lavender;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.register_btn.Location = new System.Drawing.Point(3, 145);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(197, 25);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.login_layout);
            this.Controls.Add(this.profile_picture);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(210, 188);
            this.Load += new System.EventHandler(this.AccountControl_Load);
            this.login_layout.ResumeLayout(false);
            this.login_layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button profile_picture;
        private System.Windows.Forms.FlowLayoutPanel login_layout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_input_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input_password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_btn;
    }
}
