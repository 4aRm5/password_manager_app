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

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswdManager_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void PasswdManager_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.White;
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor= Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.White;
        }
    }
}
