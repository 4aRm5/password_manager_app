namespace Курсач
{
    partial class NewService
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelServiceName = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.labelNewCard = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelHide = new System.Windows.Forms.Panel();
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panelHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPassword.Location = new System.Drawing.Point(88, 243);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 17);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "password:";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPassword.Location = new System.Drawing.Point(89, 263);
            this.textPassword.Name = "textPassword";
            this.textPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textPassword.Size = new System.Drawing.Size(225, 27);
            this.textPassword.TabIndex = 29;
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(319, -14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 16);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "X";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.White;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Location = new System.Drawing.Point(86, 182);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 17);
            this.labelLogin.TabIndex = 27;
            this.labelLogin.Text = "login:";
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.BackColor = System.Drawing.Color.White;
            this.labelServiceName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServiceName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelServiceName.Location = new System.Drawing.Point(86, 122);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(93, 17);
            this.labelServiceName.TabIndex = 26;
            this.labelServiceName.Text = "service name:";
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnButton.Location = new System.Drawing.Point(170, 345);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(57, 17);
            this.returnButton.TabIndex = 25;
            this.returnButton.Text = "Go Back";
            this.returnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.returnButton_MouseClick);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(138, 306);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 36);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add Service";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButton_MouseClick);
            // 
            // labelNewCard
            // 
            this.labelNewCard.AutoSize = true;
            this.labelNewCard.BackColor = System.Drawing.Color.White;
            this.labelNewCard.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNewCard.Location = new System.Drawing.Point(51, 64);
            this.labelNewCard.Name = "labelNewCard";
            this.labelNewCard.Size = new System.Drawing.Size(283, 45);
            this.labelNewCard.TabIndex = 22;
            this.labelNewCard.Text = "Add Your Service";
            this.labelNewCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.Location = new System.Drawing.Point(89, 202);
            this.textLogin.Name = "textLogin";
            this.textLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textLogin.Size = new System.Drawing.Size(225, 27);
            this.textLogin.TabIndex = 21;
            this.textLogin.Enter += new System.EventHandler(this.textLogin_Enter);
            this.textLogin.Leave += new System.EventHandler(this.textLogin_Leave);
            // 
            // textServiceName
            // 
            this.textServiceName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textServiceName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textServiceName.Location = new System.Drawing.Point(89, 142);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textServiceName.Size = new System.Drawing.Size(225, 27);
            this.textServiceName.TabIndex = 20;
            this.textServiceName.Enter += new System.EventHandler(this.textServiceName_Enter);
            this.textServiceName.Leave += new System.EventHandler(this.textServiceName_Leave);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMove.Location = new System.Drawing.Point(-2, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(316, 23);
            this.panelMove.TabIndex = 33;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHide.Controls.Add(this.pictureHide);
            this.panelHide.Location = new System.Drawing.Point(310, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(45, 23);
            this.panelHide.TabIndex = 32;
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
            this.panelExit.Location = new System.Drawing.Point(352, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(45, 23);
            this.panelExit.TabIndex = 31;
            this.panelExit.Click += new System.EventHandler(this.panelExit_Click);
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
            // NewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсач.Properties.Resources.фон1;
            this.ClientSize = new System.Drawing.Size(397, 553);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelServiceName);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.labelNewCard);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textServiceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newService";
            this.panelHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.Label returnButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelNewCard;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textServiceName;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}