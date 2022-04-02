namespace CO2_Interface.WinForms
{
    partial class frmRegister
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.Label();
            this.RegConPassword = new System.Windows.Forms.TextBox();
            this.txtConPassword = new System.Windows.Forms.Label();
            this.checkbxShowPas = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(96, 176);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(400, 35);
            this.txtUsername.TabIndex = 2;
            // 
            // RegPassword
            // 
            this.RegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassword.Location = new System.Drawing.Point(96, 264);
            this.RegPassword.Multiline = true;
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.PasswordChar = '•';
            this.RegPassword.Size = new System.Drawing.Size(400, 35);
            this.RegPassword.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Location = new System.Drawing.Point(92, 238);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(84, 23);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "Password";
            // 
            // RegConPassword
            // 
            this.RegConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegConPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConPassword.Location = new System.Drawing.Point(96, 351);
            this.RegConPassword.Multiline = true;
            this.RegConPassword.Name = "RegConPassword";
            this.RegConPassword.PasswordChar = '•';
            this.RegConPassword.Size = new System.Drawing.Size(400, 35);
            this.RegConPassword.TabIndex = 6;
            // 
            // txtConPassword
            // 
            this.txtConPassword.AutoSize = true;
            this.txtConPassword.Location = new System.Drawing.Point(92, 325);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(155, 23);
            this.txtConPassword.TabIndex = 5;
            this.txtConPassword.Text = "Confirm Password";
            // 
            // checkbxShowPas
            // 
            this.checkbxShowPas.AutoSize = true;
            this.checkbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPas.Location = new System.Drawing.Point(570, 238);
            this.checkbxShowPas.Name = "checkbxShowPas";
            this.checkbxShowPas.Size = new System.Drawing.Size(151, 27);
            this.checkbxShowPas.TabIndex = 7;
            this.checkbxShowPas.Text = "Show Password";
            this.checkbxShowPas.UseVisualStyleBackColor = true;
            this.checkbxShowPas.CheckedChanged += new System.EventHandler(this.checkbxShowPas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(391, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(391, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Already Have an Account ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(421, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Back to LOGIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbxShowPas);
            this.Controls.Add(this.RegConPassword);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.TextBox RegConPassword;
        private System.Windows.Forms.Label txtConPassword;
        private System.Windows.Forms.CheckBox checkbxShowPas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}