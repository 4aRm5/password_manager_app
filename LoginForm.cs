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
    public partial class PasswdManager : Form
    {
        public PasswdManager()
        {
            InitializeComponent();
            loginField.Text = "Login";
            loginField.ForeColor = Color.Gray;
            passwdField.Text = "Password";
            passwdField.ForeColor = Color.Gray;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Login";
                loginField.ForeColor = Color.Gray;            
            }
        }

        private void PasswdField_Enter(object sender, EventArgs e)
        {
            if (passwdField.Text == "Password")
            {
                passwdField.Text = "";
                passwdField.ForeColor = Color.Black;
            }
        }

        private void PasswdField_Leave(object sender, EventArgs e)
        {
            if (passwdField.Text == "")
            {
                passwdField.Text = "Password";
                passwdField.ForeColor = Color.Gray;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String passwd = passwdField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT * FROM users WHERE login = @ul and passwd = @up", db.GetConnection());
            command.Parameters.Add("@ul", NpgsqlTypes.NpgsqlDbType.Text).Value = login;
            command.Parameters.Add("@up", NpgsqlTypes.NpgsqlDbType.Text).Value = passwd;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Успех");
            else
                MessageBox.Show("Неудача");
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
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

        private void pictureExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
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
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point (e.X, e.Y);
        }
    }
}
