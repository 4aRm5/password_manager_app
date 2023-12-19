namespace Курсач
{
    partial class RegisterForm
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
            this.Home = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwdField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwdField2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.RepeatPassword = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.panelHide = new System.Windows.Forms.Panel();
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Home.Location = new System.Drawing.Point(278, 359);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(45, 17);
            this.Home.TabIndex = 11;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(237, 320);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(126, 36);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(437, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "passwdManager v1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(179, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwdField
            // 
            this.passwdField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwdField.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdField.Location = new System.Drawing.Point(334, 208);
            this.passwdField.Name = "passwdField";
            this.passwdField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwdField.Size = new System.Drawing.Size(225, 27);
            this.passwdField.TabIndex = 7;
            this.passwdField.UseSystemPasswordChar = true;
            this.passwdField.Enter += new System.EventHandler(this.passwdField_Enter);
            this.passwdField.Leave += new System.EventHandler(this.passwdField_Leave);
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginField.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(334, 153);
            this.loginField.Name = "loginField";
            this.loginField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginField.Size = new System.Drawing.Size(225, 27);
            this.loginField.TabIndex = 6;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // passwdField2
            // 
            this.passwdField2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwdField2.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwdField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdField2.Location = new System.Drawing.Point(334, 265);
            this.passwdField2.Name = "passwdField2";
            this.passwdField2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwdField2.Size = new System.Drawing.Size(225, 27);
            this.passwdField2.TabIndex = 12;
            this.passwdField2.UseSystemPasswordChar = true;
            this.passwdField2.Enter += new System.EventHandler(this.passwdField2_Enter);
            this.passwdField2.Leave += new System.EventHandler(this.passwdField2_Leave);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Login.Location = new System.Drawing.Point(334, 133);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(47, 17);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Password.Location = new System.Drawing.Point(334, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 17);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password:";
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.AutoSize = true;
            this.RepeatPassword.BackColor = System.Drawing.Color.White;
            this.RepeatPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RepeatPassword.Location = new System.Drawing.Point(334, 245);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(116, 17);
            this.RepeatPassword.TabIndex = 15;
            this.RepeatPassword.Text = "Repeat Password:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.White;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneNumber.Location = new System.Drawing.Point(56, 188);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(106, 17);
            this.phoneNumber.TabIndex = 19;
            this.phoneNumber.Text = "Phone Number:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Email.Location = new System.Drawing.Point(56, 133);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 17);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email:";
            // 
            // PhoneField
            // 
            this.PhoneField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneField.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneField.Location = new System.Drawing.Point(56, 208);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhoneField.Size = new System.Drawing.Size(225, 27);
            this.PhoneField.TabIndex = 17;
            this.PhoneField.Enter += new System.EventHandler(this.PhoneField_Enter);
            this.PhoneField.Leave += new System.EventHandler(this.PhoneField_Leave);
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailField.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(56, 153);
            this.EmailField.Name = "EmailField";
            this.EmailField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailField.Size = new System.Drawing.Size(225, 27);
            this.EmailField.TabIndex = 16;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHide.Controls.Add(this.pictureHide);
            this.panelHide.Location = new System.Drawing.Point(522, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(45, 23);
            this.panelHide.TabIndex = 21;
            this.panelHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHide_MouseClick);
            this.panelHide.MouseEnter += new System.EventHandler(this.panelHide_MouseEnter);
            this.panelHide.MouseLeave += new System.EventHandler(this.panelHide_MouseLeave);
            // 
            // pictureHide
            // 
            this.pictureHide.Image = global::Курсач.Properties.Resources.пряталка;
            this.pictureHide.Location = new System.Drawing.Point(9, 3);
            this.pictureHide.Name = "pictureHide";
            this.pictureHide.Size = new System.Drawing.Size(27, 17);
            this.pictureHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHide.TabIndex = 0;
            this.pictureHide.TabStop = false;
            this.pictureHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureHide_MouseClick);
            this.pictureHide.MouseEnter += new System.EventHandler(this.pictureHide_MouseEnter);
            this.pictureHide.MouseLeave += new System.EventHandler(this.pictureHide_MouseLeave);
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelExit.Controls.Add(this.pictureExit);
            this.panelExit.Location = new System.Drawing.Point(564, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(45, 23);
            this.panelExit.TabIndex = 20;
            this.panelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelExit_MouseClick);
            this.panelExit.MouseEnter += new System.EventHandler(this.panelExit_MouseEnter);
            this.panelExit.MouseLeave += new System.EventHandler(this.panelExit_MouseLeave);
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::Курсач.Properties.Resources.Крестик1;
            this.pictureExit.Location = new System.Drawing.Point(9, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(27, 22);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 0;
            this.pictureExit.TabStop = false;
            this.pictureExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureExit_MouseClick);
            this.pictureExit.MouseEnter += new System.EventHandler(this.pictureExit_MouseEnter);
            this.pictureExit.MouseLeave += new System.EventHandler(this.pictureExit_MouseLeave);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(525, 23);
            this.panelMove.TabIndex = 22;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Курсач.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.RepeatPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwdField2);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwdField);
            this.Controls.Add(this.loginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwdField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwdField2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label RepeatPassword;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Panel panelMove;
    }
}