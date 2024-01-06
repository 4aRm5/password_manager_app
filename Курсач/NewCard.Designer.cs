namespace Курсач
{
    partial class NewCard
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
            this.closeButton = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNumberCard = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.labelNewCard = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textCardNumber = new System.Windows.Forms.TextBox();
            this.labelCVC = new System.Windows.Forms.Label();
            this.textCVC = new System.Windows.Forms.TextBox();
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
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(326, -14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 16);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "X";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDate.Location = new System.Drawing.Point(89, 195);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 17);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "date:";
            // 
            // labelNumberCard
            // 
            this.labelNumberCard.AutoSize = true;
            this.labelNumberCard.BackColor = System.Drawing.Color.White;
            this.labelNumberCard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNumberCard.Location = new System.Drawing.Point(89, 135);
            this.labelNumberCard.Name = "labelNumberCard";
            this.labelNumberCard.Size = new System.Drawing.Size(91, 17);
            this.labelNumberCard.TabIndex = 15;
            this.labelNumberCard.Text = "card number:";
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnButton.Location = new System.Drawing.Point(170, 358);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(57, 17);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Go Back";
            this.returnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.returnButton_MouseClick);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(138, 319);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 36);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add Card";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButton_MouseClick);
            // 
            // labelNewCard
            // 
            this.labelNewCard.AutoSize = true;
            this.labelNewCard.BackColor = System.Drawing.Color.White;
            this.labelNewCard.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNewCard.Location = new System.Drawing.Point(71, 72);
            this.labelNewCard.Name = "labelNewCard";
            this.labelNewCard.Size = new System.Drawing.Size(243, 45);
            this.labelNewCard.TabIndex = 11;
            this.labelNewCard.Text = "Add Your Card";
            this.labelNewCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDate
            // 
            this.textDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDate.Location = new System.Drawing.Point(89, 215);
            this.textDate.Name = "textDate";
            this.textDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textDate.Size = new System.Drawing.Size(225, 27);
            this.textDate.TabIndex = 10;
            this.textDate.Enter += new System.EventHandler(this.textDate_Enter);
            this.textDate.Leave += new System.EventHandler(this.textDate_Leave);
            // 
            // textCardNumber
            // 
            this.textCardNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCardNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.textCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCardNumber.Location = new System.Drawing.Point(89, 155);
            this.textCardNumber.Name = "textCardNumber";
            this.textCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textCardNumber.Size = new System.Drawing.Size(225, 27);
            this.textCardNumber.TabIndex = 9;
            this.textCardNumber.Enter += new System.EventHandler(this.textCardNumber_Enter);
            this.textCardNumber.Leave += new System.EventHandler(this.textCardNumber_Leave);
            // 
            // labelCVC
            // 
            this.labelCVC.AutoSize = true;
            this.labelCVC.BackColor = System.Drawing.Color.White;
            this.labelCVC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCVC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCVC.Location = new System.Drawing.Point(89, 256);
            this.labelCVC.Name = "labelCVC";
            this.labelCVC.Size = new System.Drawing.Size(37, 17);
            this.labelCVC.TabIndex = 19;
            this.labelCVC.Text = "CVC:";
            // 
            // textCVC
            // 
            this.textCVC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCVC.Cursor = System.Windows.Forms.Cursors.Default;
            this.textCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCVC.Location = new System.Drawing.Point(89, 276);
            this.textCVC.Name = "textCVC";
            this.textCVC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textCVC.Size = new System.Drawing.Size(225, 27);
            this.textCVC.TabIndex = 18;
            this.textCVC.Enter += new System.EventHandler(this.textCVC_Enter);
            this.textCVC.Leave += new System.EventHandler(this.textCVC_Leave);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMove.Location = new System.Drawing.Point(-2, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(316, 23);
            this.panelMove.TabIndex = 22;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHide.Controls.Add(this.pictureHide);
            this.panelHide.Location = new System.Drawing.Point(311, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(45, 23);
            this.panelHide.TabIndex = 21;
            this.panelHide.Click += new System.EventHandler(this.panelHide_Click);
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
            this.panelExit.Location = new System.Drawing.Point(353, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(45, 23);
            this.panelExit.TabIndex = 20;
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
            // NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсач.Properties.Resources.фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(397, 553);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.labelCVC);
            this.Controls.Add(this.textCVC);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNumberCard);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.labelNewCard);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textCardNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCard";
            this.panelHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNumberCard;
        private System.Windows.Forms.Label returnButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelNewCard;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textCardNumber;
        private System.Windows.Forms.Label labelCVC;
        private System.Windows.Forms.TextBox textCVC;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}