using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            int addService_X = 86, addService_Y = 100;
            int serviceName_X = 97;
            int serviceName_Y = 102;
            int serviceLogin_Y = 102;
            int servicePasswd_Y = 102;
            int pSN_X = 90;
            int pSN_Y = 100;
            int pSL_Y = 100;
            int pSP_Y = 100;

            DB db = new DB();

            DataTable table = new DataTable();

            Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT service_name, login_service, passwd_service FROM services", db.GetConnection(PasswdManager.login, PasswdManager.password));

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow[] rows = table.Select();
            
            if (table.Rows.Count > 0 ) 
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    Label serviceName = new Label();
                    Label serviceLogin = new Label();
                    Label servicePasswd = new Label();

                    Panel pSN = new Panel();
                    Panel pSL = new Panel();
                    Panel pSP = new Panel();

                    serviceName.Location = new Point(serviceName_X, serviceName_Y);
                    serviceName.AutoSize = true;
                    serviceName.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    serviceName.ForeColor = Color.DimGray;
                    serviceName.Name = $"serviceName{i}";
                    serviceName.Text = $"{rows[i]["service_name"]}";
                    serviceName.BackColor = SystemColors.GradientInactiveCaption;
                    serviceName.MouseEnter += new System.EventHandler(Object_MouseEnter);
                    serviceName.MouseLeave += new System.EventHandler(Object_MouseLeave);
                    serviceName.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);
                    this.Controls.Add(serviceName);

                    pSN.Location = new Point(pSN_X, pSN_Y);
                    pSN.Name = $"panelNumberCard{i}";
                    pSN.Size = new Size(serviceName.Size.Width + 13, serviceName.Size.Height + 5);
                    pSN.BackColor = SystemColors.GradientInactiveCaption;
                    this.Controls.Add(pSN);

                    int serviceLogin_X = pSN.Size.Width + 100;

                    serviceLogin.Location = new Point(serviceLogin_X, serviceLogin_Y);
                    serviceLogin.AutoSize = true;
                    serviceLogin.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    serviceLogin.ForeColor = Color.DimGray;
                    serviceLogin.Name = $"serviceLogin{i}";
                    serviceLogin.Text = $"{rows[i]["login_service"]}";
                    serviceLogin.BackColor = SystemColors.GradientInactiveCaption;
                    serviceLogin.MouseEnter += new System.EventHandler(Object_MouseEnter);
                    serviceLogin.MouseLeave += new System.EventHandler(Object_MouseLeave);
                    serviceLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);
                    this.Controls.Add(serviceLogin);

                    int pSL_X = pSN.Size.Width + 94;

                    pSL.Location = new Point(pSL_X, pSL_Y);
                    pSL.Name = $"panelDateCard{i}";
                    pSL.Size = new Size(serviceLogin.Size.Width + 13, serviceLogin.Size.Height + 5);
                    pSL.BackColor = SystemColors.GradientInactiveCaption;
                    this.Controls.Add(pSL);

                    int servicePasswd_X = pSN.Size.Width + pSL.Size.Width + 104;

                    servicePasswd.Location = new Point(servicePasswd_X, servicePasswd_Y);
                    servicePasswd.AutoSize = true;
                    servicePasswd.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    servicePasswd.ForeColor = Color.DimGray;
                    servicePasswd.Name = $"numberCard{i}";
                    servicePasswd.Text = $"{rows[i]["passwd_service"]}";
                    servicePasswd.BackColor = SystemColors.GradientInactiveCaption;
                    servicePasswd.MouseEnter += new System.EventHandler(Object_MouseEnter);
                    servicePasswd.MouseLeave += new System.EventHandler(Object_MouseLeave);
                    servicePasswd.MouseClick += new System.Windows.Forms.MouseEventHandler(Object_MouseClick);
                    this.Controls.Add(servicePasswd);

                    int pSP_X = pSN.Size.Width + pSL.Size.Width + 98;

                    pSP.Location = new Point(pSP_X, pSP_Y);
                    pSP.Name = $"panelCVC{i}";
                    pSP.Size = new Size(servicePasswd.Size.Width + 13, servicePasswd.Size.Height + 5);
                    pSP.BackColor = SystemColors.GradientInactiveCaption;
                    this.Controls.Add(pSP);

                    serviceName_Y += 45;
                    serviceLogin_Y += 45;
                    servicePasswd_Y += 45;

                    pSN_Y += 45;
                    pSL_Y += 45;
                    pSP_Y += 45;
                    addService_Y = pSN_Y;

                    if (pSN.Width + pSL.Width + pSP.Width + 66 > 518)
                    {
                        int scroll = 0;
                        hScrollBar.Visible = true;
                        hScrollBar.Scroll += new ScrollEventHandler(hScrollBar_Scroll);

                        void hScrollBar_Scroll(object sender, ScrollEventArgs e)
                        {
                            if (scroll > hScrollBar.Value)
                            {
                                serviceName.Location = new Point(serviceName.Location.X + 10, serviceName.Location.Y);
                                serviceLogin.Location = new Point(serviceLogin.Location.X + 10, serviceLogin.Location.Y);
                                servicePasswd.Location = new Point(servicePasswd.Location.X + 10, servicePasswd.Location.Y);
                                pSN.Location = new Point(pSN.Location.X + 10, pSN.Location.Y);
                                pSL.Location = new Point(pSL.Location.X + 10, pSL.Location.Y);
                                pSP.Location = new Point(pSP.Location.X + 10, pSP.Location.Y);
                            }
                            else if (scroll < hScrollBar.Value)
                            {
                                serviceName.Location = new Point(serviceName.Location.X - 10, serviceName.Location.Y);
                                serviceLogin.Location = new Point(serviceLogin.Location.X - 10, serviceLogin.Location.Y);
                                servicePasswd.Location = new Point(servicePasswd.Location.X - 10, servicePasswd.Location.Y);
                                pSN.Location = new Point(pSN.Location.X - 10, pSN.Location.Y);
                                pSL.Location = new Point(pSL.Location.X - 10, pSL.Location.Y);
                                pSP.Location = new Point(pSP.Location.X - 10, pSP.Location.Y);
                            }
                            scroll = hScrollBar.Value;
                        }
                    }

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
                            labelCopy.Location = new Point(label.Location.X, label.Location.Y + 25);
                            labelCopy.Visible = true;
                        }

                    }
                }
            }

            Button addService = new Button();
            addService.BackColor = System.Drawing.SystemColors.HotTrack;
            addService.Cursor = System.Windows.Forms.Cursors.Hand;
            addService.Font = new Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addService.Location = new Point(addService_X, addService_Y);
            addService.Name = "loginButton";
            addService.Size = new Size(100, 27);
            addService.TabIndex = 4;
            addService.Text = "Add New";
            addService.UseVisualStyleBackColor = false;
            addService.MouseClick += new MouseEventHandler(addService_MouseClick);

            this.Controls.Add(addService);
        }

        private void addService_MouseClick(object sender, MouseEventArgs e)
        {
            
            
            this.Hide();
            NewService newService = new NewService();
            newService.Show();
        }

        private void exitPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            PasswdManager loginform = new PasswdManager();
            loginform.Show();
        }

        private void pictureExit_MouseClick(object sender, MouseEventArgs e)
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

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = SystemColors.GradientActiveCaption;
        }

        private void pictureCards_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
        }

        private void panelCards_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
        }

        private void pictureCards_MouseLeave(object sender, EventArgs e)
        {
            panelCards.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureCards_MouseEnter(object sender, EventArgs e)
        {
            panelCards.BackColor = SystemColors.GradientActiveCaption;
        }

        private void panelCards_MouseEnter(object sender, EventArgs e)
        {
            panelCards.BackColor = SystemColors.GradientActiveCaption;
        }

        private void panelCards_MouseLeave(object sender, EventArgs e)
        {
            panelCards.BackColor = SystemColors.GradientInactiveCaption;
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

        private void pictureExitApp_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureExitApp_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void pictureExitApp_MouseLeave(object sender, EventArgs e)
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
