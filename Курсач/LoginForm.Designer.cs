namespace Курсач
{
    partial class PasswdManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwdField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panelHide = new System.Windows.Forms.Panel();
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.panelHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginField.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(82, 163);
            this.loginField.Name = "loginField";
            this.loginField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginField.Size = new System.Drawing.Size(225, 27);
            this.loginField.TabIndex = 0;
            this.loginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // passwdField
            // 
            this.passwdField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwdField.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdField.Location = new System.Drawing.Point(82, 223);
            this.passwdField.Name = "passwdField";
            this.passwdField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwdField.Size = new System.Drawing.Size(225, 27);
            this.passwdField.TabIndex = 1;
            this.passwdField.UseSystemPasswordChar = true;
            this.passwdField.Enter += new System.EventHandler(this.PasswdField_Enter);
            this.passwdField.Leave += new System.EventHandler(this.PasswdField_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(127, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(234, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "passwdManager v1.0";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(136, 271);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(126, 36);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createAccount.Location = new System.Drawing.Point(142, 310);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(101, 17);
            this.createAccount.TabIndex = 5;
            this.createAccount.Text = "Create Account";
            this.createAccount.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(82, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(82, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "password:";
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelExit.Controls.Add(this.pictureExit);
            this.panelExit.Location = new System.Drawing.Point(353, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(45, 23);
            this.panelExit.TabIndex = 8;
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
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHide.Controls.Add(this.pictureHide);
            this.panelHide.Location = new System.Drawing.Point(311, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(45, 23);
            this.panelHide.TabIndex = 9;
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
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMove.Location = new System.Drawing.Point(-2, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(316, 23);
            this.panelMove.TabIndex = 10;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // PasswdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Курсач.Properties.Resources.фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(397, 553);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwdField);
            this.Controls.Add(this.loginField);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswdManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passwdManager";
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.panelHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwdField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Panel panelMove;
    }
}

