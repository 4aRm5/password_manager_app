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
    public partial class NewService : Form
    {
        public NewService()
        {
            InitializeComponent();

            textServiceName.Text = "Service name";
            textServiceName.ForeColor = Color.Gray;
            textLogin.Text = "Service login";
            textLogin.ForeColor = Color.Gray;
            textPassword.Text = "Service password";
            textPassword.ForeColor = Color.Gray;
        }

        private void textServiceName_Enter(object sender, EventArgs e)
        {
            if (textServiceName.Text == "Service name")
            {
                textServiceName.Text = "";
                textServiceName.ForeColor = Color.Black;
            }
        }

        private void textServiceName_Leave(object sender, EventArgs e)
        {
            if (textServiceName.Text == "")
            {
                textServiceName.Text = "Service name";
                textServiceName.ForeColor = Color.Gray;
            }
        }

        private void textLogin_Enter(object sender, EventArgs e)
        {
            if (textLogin.Text == "Service login")
            {
                textLogin.Text = "";
                textLogin.ForeColor = Color.Black;
            }
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
            {
                textLogin.Text = "Service login";
                textLogin.ForeColor = Color.Gray;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Service password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Service password";
                textPassword.ForeColor = Color.Gray;
            }
        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {

            if (textServiceName.Text == "")
            {
                MessageBox.Show("Введите имя сервиса");
                labelServiceName.ForeColor = Color.Red;

                labelLogin.ForeColor = SystemColors.HotTrack;
                labelPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (textLogin.Text == "")
            {
                MessageBox.Show("Введите логин");
                labelLogin.ForeColor = Color.Red;

                labelServiceName.ForeColor = SystemColors.HotTrack;
                labelPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (textPassword.Text == "")
            {
                MessageBox.Show("Введите пароль");
                labelPassword.ForeColor = Color.Red;

                labelLogin.ForeColor = SystemColors.HotTrack;
                labelServiceName.ForeColor = SystemColors.HotTrack;
            }
            else
            {
                string serviceName = textServiceName.Text;
                string serviceLogin = textLogin.Text;
                string servicePassword = textPassword.Text;

                DB db = new DB();

                DataTable table = new DataTable();

                Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT * FROM credits WHERE service_name = @sn and login_service = @sl and passwd_service = @sp", db.GetConnection(PasswdManager.login, PasswdManager.password));
                command.Parameters.Add("@sn", NpgsqlTypes.NpgsqlDbType.Text).Value = serviceName;
                command.Parameters.Add("@sl", NpgsqlTypes.NpgsqlDbType.Text).Value = serviceLogin;
                command.Parameters.Add("@sp", NpgsqlTypes.NpgsqlDbType.Text).Value = servicePassword;

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show($"Вы уже сохраняли эти данные для {serviceName}!");
                }
                else
                {
                    command = new Npgsql.NpgsqlCommand("SELECT insert_service(@sn, @sl, @sp)", db.GetConnection(PasswdManager.login, PasswdManager.password));
                    command.Parameters.Add("@sn", NpgsqlTypes.NpgsqlDbType.Text).Value = serviceName;
                    command.Parameters.Add("@sl", NpgsqlTypes.NpgsqlDbType.Text).Value = serviceLogin;
                    command.Parameters.Add("@sp", NpgsqlTypes.NpgsqlDbType.Text).Value = servicePassword;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    MessageBox.Show("Данные успешно добавлены!");
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
            }
        }

        private void returnButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void pictureExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureHide_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void panelExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void panelExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureHide_MouseEnter(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientActiveCaption;
        }

        private void pictureHide_MouseLeave(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void panelHide_MouseEnter(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientActiveCaption;
        }

        private void panelHide_MouseLeave(object sender, EventArgs e)
        {
            panelHide.BackColor = SystemColors.GradientInactiveCaption;
        }

        Point lastPoint;
        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
