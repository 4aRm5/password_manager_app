using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Курсач
{
    public partial class MainMenu2 : Form
    {
        public MainMenu2()
        {
            InitializeComponent();
            int panelNumberCard_X = 86;
            int panelNumberCard_Y = 100;
            int panelNumberCard_Size_X = 191;
            int panelNumberCard_Size_Y = 25;
            int panelDateCard_X = 290;
            int panelDateCard_Y = 100;
            int panelDateCard_Size_X = 53;
            int panelDateCard_Size_Y = 25;
            int panelCVC_X = 355;
            int panelCVC_Y = 100;
            int panelCVC_Size_X = 36;
            int panelCVC_Size_Y = 25;

            int numberCard_X = 97;
            int numberCard_Y = 102;
            int dateCard_X = 290;
            int dateCard_Y = 102;
            int cvc_X = 355;
            int cvc_Y = 102;

            DB db = new DB();

            DataTable table = new DataTable();

            Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT credit_number, credit_date, credit_code FROM credits", db.GetConnection(PasswdManager.login, PasswdManager.password));

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow[] rows = table.Select();

            for (int i = 0; i < table.Rows.Count; i++)
            {

                Label numberCard = new Label();
                Label dateCard = new Label();
                Label cvc = new Label();

                Panel pNC = new Panel();
                Panel pDC = new Panel();
                Panel pCVC = new Panel();

                numberCard.Location = new Point(numberCard_X, numberCard_Y);
                numberCard.AutoSize = true;
                numberCard.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                numberCard.ForeColor = Color.DimGray;
                numberCard.Name = $"numberCard{i}";
                numberCard.Text = $"{rows[i]["credit_number"]}";
                numberCard.BackColor = SystemColors.GradientInactiveCaption;
                numberCard.MouseEnter += new System.EventHandler(Object_MouseEnter);
                numberCard.MouseLeave += new System.EventHandler(Object_MouseLeave);
                numberCard.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);


                dateCard.Location = new Point(dateCard_X, dateCard_Y);
                dateCard.AutoSize = true;
                dateCard.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dateCard.ForeColor = Color.DimGray;
                dateCard.Name = $"numberCard{i}";
                dateCard.Text = $"{rows[i]["credit_date"]}";
                dateCard.BackColor = SystemColors.GradientInactiveCaption;
                dateCard.MouseEnter += new System.EventHandler(Object_MouseEnter);
                dateCard.MouseLeave += new System.EventHandler(Object_MouseLeave);
                dateCard.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);


                cvc.Location = new Point(cvc_X, cvc_Y);
                cvc.AutoSize = true;
                cvc.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cvc.ForeColor = Color.DimGray;
                cvc.Name = $"numberCard{i}";
                cvc.Text = $"{rows[i]["credit_code"]}";
                cvc.BackColor = SystemColors.GradientInactiveCaption;
                cvc.MouseEnter += new System.EventHandler(Object_MouseEnter);
                cvc.MouseLeave += new System.EventHandler(Object_MouseLeave);
                cvc.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);

                this.Controls.Add(numberCard);
                this.Controls.Add(dateCard);
                this.Controls.Add(cvc);

                numberCard_Y += 45;
                dateCard_Y += 45;
                cvc_Y += 45;

                pNC.Location = new Point(panelNumberCard_X, panelNumberCard_Y);
                pNC.Name = $"panelNumberCard{i}";
                pNC.Size = new Size(panelNumberCard_Size_X, panelNumberCard_Size_Y);
                pNC.BackColor = SystemColors.GradientInactiveCaption;

                pDC.Location = new Point(panelDateCard_X, panelDateCard_Y);
                pDC.Name = $"panelDateCard{i}";
                pDC.Size = new Size(panelDateCard_Size_X, panelDateCard_Size_Y);
                pDC.BackColor = SystemColors.GradientInactiveCaption;

                pCVC.Location = new Point(panelCVC_X, panelCVC_Y);
                pCVC.Name = $"panelCVC{i}";
                pCVC.Size = new Size(panelCVC_Size_X, panelCVC_Size_Y);
                pCVC.BackColor = SystemColors.GradientInactiveCaption;

                this.Controls.Add(pNC);
                this.Controls.Add(pDC);
                this.Controls.Add(pCVC);

                panelNumberCard_Y += 45;
                panelDateCard_Y += 45;
                panelCVC_Y += 45;

                void Object_MouseEnter(object sender, EventArgs e)
                {
                    var label = (Label)sender;
                    label.ForeColor = Color.Black;
                }
                void Object_MouseLeave(object sender, EventArgs e)
                {
                    var label = (Label)sender;
                    label.ForeColor = Color.DimGray;
                }
                void Object_MouseClick(object sender, EventArgs e)
                {
                    Label label = (Label)sender;

                    if (label != null)
                    {
                        Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);
                        labelCopy.Location = new Point(label.Location.X,label.Location.Y+25);
                        labelCopy.Visible = true;
                    }
                }
            }

            Button addCard = new Button();
            addCard.BackColor = System.Drawing.SystemColors.HotTrack;
            addCard.Cursor = System.Windows.Forms.Cursors.Hand;
            addCard.Font = new Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addCard.Location = new Point(panelNumberCard_X, panelNumberCard_Y);
            addCard.Name = "loginButton";
            addCard.Size = new Size(100, 27);
            addCard.TabIndex = 4;
            addCard.Text = "Add New";
            addCard.UseVisualStyleBackColor = false;
            addCard.MouseClick += new MouseEventHandler(addCard_MouseClick);

            this.Controls.Add(addCard);

        }

        private void addCard_MouseClick(object sender , MouseEventArgs e)
        {
            this.Hide();
            NewCard newCard = new NewCard();
            newCard.Show();
        }

        private void picturePasswd_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void picturePasswd_MouseEnter(object sender, EventArgs e)
        {
            panelPasswd.BackColor = SystemColors.GradientActiveCaption;
        }

        private void picturePasswd_MouseLeave(object sender, EventArgs e)
        {
            panelPasswd.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void panelPasswd_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void panelPasswd_MouseEnter(object sender, EventArgs e)
        {
            panelPasswd.BackColor = SystemColors.GradientActiveCaption;
        }

        private void panelPasswd_MouseLeave(object sender, EventArgs e)
        {
            panelPasswd.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void exitPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            PasswdManager loginform = new PasswdManager();
            loginform.Show();
        }

        private void exitPanel_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientActiveCaption;
        }

        private void exitPanel_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            PasswdManager loginform = new PasswdManager();
            loginform.Show();
        }

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientActiveCaption;
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureHide_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureHide_MouseEnter(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientActiveCaption;
        }

        private void pictureHide_MouseLeave(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void panelHide_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHide_MouseEnter(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientActiveCaption;
        }

        private void panelHide_MouseLeave(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureExitApp2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureExitApp2_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void pictureExitApp2_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void panelExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panelExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void panelExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = SystemColors.GradientInactiveCaption;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
