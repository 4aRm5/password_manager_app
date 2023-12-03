using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            loginField.Text = "Login";
            loginField.ForeColor = Color.Gray;
            passwdField.Text = "Password";
            passwdField.ForeColor = Color.Gray;
            passwdField2.Text = "Password";
            passwdField2.ForeColor = Color.Gray;
            EmailField.Text = "Email";
            EmailField.ForeColor = Color.Gray;
            PhoneField.Text = "Phone Number";
            PhoneField.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Login";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passwdField_Enter(object sender, EventArgs e)
        {
            if (passwdField.Text == "Password")
            {
                passwdField.Text = "";
                passwdField.ForeColor = Color.Black;
            }
        }

        private void passwdField_Leave(object sender, EventArgs e)
        {
            if (passwdField.Text == "")
            {
                passwdField.Text = "Password";
                passwdField.ForeColor = Color.Gray;
            }
        }

        private void passwdField2_Enter(object sender, EventArgs e)
        {
            if (passwdField2.Text == "Password")
            {
                passwdField2.Text = "";
                passwdField2.ForeColor = Color.Black;
            }
        }

        private void passwdField2_Leave(object sender, EventArgs e)
        {
            if (passwdField2.Text == "")
            {
                passwdField2.Text = "Password";
                passwdField2.ForeColor = Color.Gray;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswdManager loginform = new PasswdManager();
            loginform.Show();
        }
        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Email")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Email";
                EmailField.ForeColor = Color.Gray;
            }
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Phone Number")
            {
                PhoneField.Text = "";
                PhoneField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (PhoneField.Text == "")
            {
                PhoneField.Text = "Phone Number";
                PhoneField.ForeColor = Color.Gray;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String passwd = passwdField.Text;
            String email = EmailField.Text;
            String phone = PhoneField.Text;
            Regex phoneRegex = new Regex("^\\+?[1-9][0-9]{7,14}$");
            Regex emailRegex = new Regex("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,6}$");


            if (EmailField.Text == "Email" || emailRegex.IsMatch(EmailField.Text) == false)
            {
                MessageBox.Show("Неверный формат почты");
                Email.ForeColor = Color.Red;

                phoneNumber.ForeColor = SystemColors.HotTrack;
                Login.ForeColor = SystemColors.HotTrack;
                Password.ForeColor = SystemColors.HotTrack;
                RepeatPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (PhoneField.Text == "Phone Number" || phoneRegex.IsMatch(PhoneField.Text) == false)
            {
                MessageBox.Show("Неверный формат телефона");
                phoneNumber.ForeColor = Color.Red;

                Email.ForeColor = SystemColors.HotTrack;
                Login.ForeColor = SystemColors.HotTrack;
                Password.ForeColor = SystemColors.HotTrack;
                RepeatPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (loginField.Text == "" || loginField.Text == "Login")
            {
                MessageBox.Show("Введите логин");
                Login.ForeColor = Color.Red;

                Email.ForeColor = SystemColors.HotTrack;
                phoneNumber.ForeColor = SystemColors.HotTrack;
                Password.ForeColor = SystemColors.HotTrack;
                RepeatPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (passwdField.Text == "Password")
            {
                MessageBox.Show("Недопустимое занчение пароля");
                Password.ForeColor = Color.Red;

                Email.ForeColor = SystemColors.HotTrack;
                phoneNumber.ForeColor = SystemColors.HotTrack;
                Login.ForeColor = SystemColors.HotTrack;
                RepeatPassword.ForeColor = SystemColors.HotTrack;
            }
            else if (passwdField.Text != passwdField2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                Password.ForeColor = Color.Red;
                RepeatPassword.ForeColor = Color.Red;

                Email.ForeColor = SystemColors.HotTrack;
                phoneNumber.ForeColor = SystemColors.HotTrack;
                Login.ForeColor = SystemColors.HotTrack;
            }
            else
            {
                DB db = new DB();

                DataTable table = new DataTable();

                Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT * FROM users WHERE email = @um or phone_number = @uph or login = @ul", db.GetConnection());
                command.Parameters.Add("@um", NpgsqlTypes.NpgsqlDbType.Text).Value = email;
                command.Parameters.Add("@uph", NpgsqlTypes.NpgsqlDbType.Text).Value = phone;
                command.Parameters.Add("@ul", NpgsqlTypes.NpgsqlDbType.Text).Value = login;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с такими данными уже существует");
                }
                else
                {
                    command = new Npgsql.NpgsqlCommand("INSERT INTO users (email, passwd, phone_number, login) values (@um, @up, @uph, @ul)", db.GetConnection());
                    command.Parameters.Add("@um", NpgsqlTypes.NpgsqlDbType.Text).Value = email;
                    command.Parameters.Add("@up", NpgsqlTypes.NpgsqlDbType.Text).Value = passwd;
                    command.Parameters.Add("@uph", NpgsqlTypes.NpgsqlDbType.Text).Value = phone;
                    command.Parameters.Add("@ul", NpgsqlTypes.NpgsqlDbType.Text).Value = login;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    MessageBox.Show("Успешная Регистрация");
                    this.Hide();
                    PasswdManager loginform = new PasswdManager();
                    loginform.Show();
                }
            }
        }
    }
}
