﻿namespace Курсач
{
    partial class MainMenu2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCards = new System.Windows.Forms.Panel();
            this.pictureCards = new System.Windows.Forms.PictureBox();
            this.panelPasswd = new System.Windows.Forms.Panel();
            this.picturePasswd = new System.Windows.Forms.PictureBox();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.pictureExitApp = new System.Windows.Forms.PictureBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelHide = new System.Windows.Forms.Panel();
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureExitApp2 = new System.Windows.Forms.PictureBox();
            this.labelCopy = new System.Windows.Forms.Label();
            this.labelYourCards = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCards)).BeginInit();
            this.panelPasswd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswd)).BeginInit();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitApp)).BeginInit();
            this.panelHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitApp2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panelCards);
            this.panel1.Controls.Add(this.panelPasswd);
            this.panel1.Controls.Add(this.exitPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 553);
            this.panel1.TabIndex = 1;
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelCards.Controls.Add(this.pictureCards);
            this.panelCards.Location = new System.Drawing.Point(0, 96);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(91, 73);
            this.panelCards.TabIndex = 2;
            // 
            // pictureCards
            // 
            this.pictureCards.Image = global::Курсач.Properties.Resources.карты;
            this.pictureCards.Location = new System.Drawing.Point(6, 3);
            this.pictureCards.Name = "pictureCards";
            this.pictureCards.Size = new System.Drawing.Size(72, 67);
            this.pictureCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCards.TabIndex = 0;
            this.pictureCards.TabStop = false;
            // 
            // panelPasswd
            // 
            this.panelPasswd.Controls.Add(this.picturePasswd);
            this.panelPasswd.Location = new System.Drawing.Point(0, 23);
            this.panelPasswd.Name = "panelPasswd";
            this.panelPasswd.Size = new System.Drawing.Size(91, 73);
            this.panelPasswd.TabIndex = 1;
            this.panelPasswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPasswd_MouseClick);
            this.panelPasswd.MouseEnter += new System.EventHandler(this.panelPasswd_MouseEnter);
            this.panelPasswd.MouseLeave += new System.EventHandler(this.panelPasswd_MouseLeave);
            // 
            // picturePasswd
            // 
            this.picturePasswd.Image = global::Курсач.Properties.Resources.пароли1;
            this.picturePasswd.Location = new System.Drawing.Point(12, 9);
            this.picturePasswd.Name = "picturePasswd";
            this.picturePasswd.Size = new System.Drawing.Size(66, 56);
            this.picturePasswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswd.TabIndex = 0;
            this.picturePasswd.TabStop = false;
            this.picturePasswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturePasswd_MouseClick);
            this.picturePasswd.MouseEnter += new System.EventHandler(this.picturePasswd_MouseEnter);
            this.picturePasswd.MouseLeave += new System.EventHandler(this.picturePasswd_MouseLeave);
            // 
            // exitPanel
            // 
            this.exitPanel.Controls.Add(this.pictureExit);
            this.exitPanel.Location = new System.Drawing.Point(3, 480);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(85, 70);
            this.exitPanel.TabIndex = 0;
            this.exitPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitPanel_MouseClick);
            this.exitPanel.MouseEnter += new System.EventHandler(this.exitPanel_MouseEnter);
            this.exitPanel.MouseLeave += new System.EventHandler(this.exitPanel_MouseLeave);
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::Курсач.Properties.Resources.Выход;
            this.pictureExit.Location = new System.Drawing.Point(3, 15);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(82, 43);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 0;
            this.pictureExit.TabStop = false;
            this.pictureExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureExit_MouseClick);
            this.pictureExit.MouseEnter += new System.EventHandler(this.pictureExit_MouseEnter);
            this.pictureExit.MouseLeave += new System.EventHandler(this.pictureExit_MouseLeave);
            // 
            // pictureExitApp
            // 
            this.pictureExitApp.Location = new System.Drawing.Point(0, 0);
            this.pictureExitApp.Name = "pictureExitApp";
            this.pictureExitApp.Size = new System.Drawing.Size(100, 50);
            this.pictureExitApp.TabIndex = 0;
            this.pictureExitApp.TabStop = false;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.BackColor = System.Drawing.Color.White;
            this.labelCardNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCardNumber.Location = new System.Drawing.Point(112, 91);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(222, 23);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number | Date | CVC";
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(527, 23);
            this.panelMove.TabIndex = 28;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHide.Controls.Add(this.pictureHide);
            this.panelHide.Location = new System.Drawing.Point(524, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(45, 23);
            this.panelHide.TabIndex = 27;
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
            this.panelExit.Controls.Add(this.pictureExitApp2);
            this.panelExit.Location = new System.Drawing.Point(566, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(45, 23);
            this.panelExit.TabIndex = 26;
            this.panelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelExit_MouseClick);
            this.panelExit.MouseEnter += new System.EventHandler(this.panelExit_MouseEnter);
            this.panelExit.MouseLeave += new System.EventHandler(this.panelExit_MouseLeave);
            // 
            // pictureExitApp2
            // 
            this.pictureExitApp2.Image = global::Курсач.Properties.Resources.Крестик1;
            this.pictureExitApp2.Location = new System.Drawing.Point(9, 0);
            this.pictureExitApp2.Name = "pictureExitApp2";
            this.pictureExitApp2.Size = new System.Drawing.Size(27, 22);
            this.pictureExitApp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExitApp2.TabIndex = 0;
            this.pictureExitApp2.TabStop = false;
            this.pictureExitApp2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureExitApp2_MouseClick);
            this.pictureExitApp2.MouseEnter += new System.EventHandler(this.pictureExitApp2_MouseEnter);
            this.pictureExitApp2.MouseLeave += new System.EventHandler(this.pictureExitApp2_MouseLeave);
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.BackColor = System.Drawing.Color.White;
            this.labelCopy.Font = new System.Drawing.Font("Segoe UI", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopy.ForeColor = System.Drawing.Color.DimGray;
            this.labelCopy.Location = new System.Drawing.Point(114, 458);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(42, 12);
            this.labelCopy.TabIndex = 29;
            this.labelCopy.Text = "Copied*";
            this.labelCopy.Visible = false;
            // 
            // labelYourCards
            // 
            this.labelYourCards.AutoSize = true;
            this.labelYourCards.BackColor = System.Drawing.Color.White;
            this.labelYourCards.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourCards.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelYourCards.Location = new System.Drawing.Point(107, 32);
            this.labelYourCards.Name = "labelYourCards";
            this.labelYourCards.Size = new System.Drawing.Size(208, 50);
            this.labelYourCards.TabIndex = 30;
            this.labelYourCards.Text = "Your Cards";
            // 
            // MainMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсач.Properties.Resources.фон1;
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.labelYourCards);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu2";
            this.panel1.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCards)).EndInit();
            this.panelPasswd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswd)).EndInit();
            this.exitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitApp)).EndInit();
            this.panelHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitApp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.PictureBox pictureCards;
        private System.Windows.Forms.Panel panelPasswd;
        private System.Windows.Forms.PictureBox picturePasswd;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.PictureBox pictureExitApp;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox pictureExitApp2;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Label labelYourCards;
    }
}