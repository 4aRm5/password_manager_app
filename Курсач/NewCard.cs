using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Курсач
{
    public partial class NewCard : Form
    {
        public NewCard()
        {
            InitializeComponent();
            textCardNumber.Text = "Card number";
            textCardNumber.ForeColor = Color.Gray;
            textDate.Text = "Date xx/xx";
            textDate.ForeColor = Color.Gray;
            textCVC.Text = "CVC code";
            textCVC.ForeColor = Color.Gray;

        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            string formatCardNumber = "";
            string checkDate = "";
            int count = 0;

            Regex cardNumberRegex = new Regex("[0-9]{16}$");
            Regex dateRegex = new Regex("[0-9][0-9]/[0-9][0-9]");
            Regex cvcRegex = new Regex("[0-9]{3}$");

            if (textCardNumber.Text.Length == 16)
            {
                formatCardNumber = textCardNumber.Text;
                formatCardNumber = textCardNumber.Text.Insert(4, " ");
                formatCardNumber = formatCardNumber.Insert(9, " ");
                formatCardNumber = formatCardNumber.Insert(14, " ");

            }

            if (dateRegex.IsMatch(textDate.Text) == false)
            {
                MessageBox.Show("Неверная дата!");
                labelDate.ForeColor = Color.Red;

                labelNumberCard.ForeColor = SystemColors.HotTrack;
                labelCVC.ForeColor = SystemColors.HotTrack;
                return;
            }
            else
            {

                for (int i = 0; i < textDate.Text.Length; i++)
                {
                    if (textDate.Text[i] != '/')
                    {
                        count += 1;
                        checkDate += Convert.ToString(textDate.Text[i]);
                        if (count == 2)
                        {
                            if (Convert.ToInt32(checkDate) > 12)
                            {

                                MessageBox.Show("Неверная дата!");
                                labelDate.ForeColor = Color.Red;

                                labelNumberCard.ForeColor = SystemColors.HotTrack;
                                labelCVC.ForeColor = SystemColors.HotTrack;
                                return;
                            }
                            checkDate = "";
                        }
                        else
                        {
                            if (Convert.ToInt32(checkDate) > 99)
                            {

                                MessageBox.Show("Неверная дата!");
                                labelDate.ForeColor = Color.Red;

                                labelNumberCard.ForeColor = SystemColors.HotTrack;
                                labelCVC.ForeColor = SystemColors.HotTrack;
                                return;
                            }
                        }
                    }
                }
            }

            if (cardNumberRegex.IsMatch(textCardNumber.Text) == false)
            {
                MessageBox.Show("Неверный номер карты!");
                labelNumberCard.ForeColor = Color.Red;

                labelDate.ForeColor = SystemColors.HotTrack;
                labelCVC.ForeColor = SystemColors.HotTrack;
            }

            else if (dateRegex.IsMatch(textDate.Text) == false)
            {
                MessageBox.Show("Неверная дата!");
                labelDate.ForeColor = Color.Red;

                labelNumberCard.ForeColor = SystemColors.HotTrack;
                labelCVC.ForeColor = SystemColors.HotTrack;
            }

            else if (cvcRegex.IsMatch(textCVC.Text) == false || textCVC.Text.Length != 3)
            {
                MessageBox.Show("Неверный СVC код!");
                labelCVC.ForeColor = Color.Red;

                labelDate.ForeColor = SystemColors.HotTrack;
                labelNumberCard.ForeColor = SystemColors.HotTrack;
            }

            else
            {
                string cardNumber = formatCardNumber;
                string date = textDate.Text;
                string cvc = textCVC.Text;

                DB db = new DB();

                DataTable table = new DataTable();

                Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter();

                Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("SELECT * FROM credits WHERE credit_number = @cn and credit_date = @cd and credit_code = @cc", db.GetConnection(PasswdManager.login, PasswdManager.password));
                command.Parameters.Add("@cn", NpgsqlTypes.NpgsqlDbType.Text).Value = cardNumber;
                command.Parameters.Add("@cd", NpgsqlTypes.NpgsqlDbType.Text).Value = date;
                command.Parameters.Add("@cc", NpgsqlTypes.NpgsqlDbType.Text).Value = cvc;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Вы уже сохраняли эту карту!");
                }
                else
                {
                    command = new Npgsql.NpgsqlCommand("SELECT insert_credit(@cn, @cd, @cc)", db.GetConnection(PasswdManager.login, PasswdManager.password));
                    command.Parameters.Add("@cn", NpgsqlTypes.NpgsqlDbType.Text).Value = cardNumber;
                    command.Parameters.Add("@cd", NpgsqlTypes.NpgsqlDbType.Text).Value = date;
                    command.Parameters.Add("@cc", NpgsqlTypes.NpgsqlDbType.Text).Value = cvc;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    MessageBox.Show("Карта успешно добавлена!");
                    this.Hide();
                    MainMenu2 mainMenu2 = new MainMenu2();
                    mainMenu2.Show();
                }
            }


        }

        private void returnButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
        }

        private void textCardNumber_Enter(object sender, EventArgs e)
        {
            if (textCardNumber.Text == "Card number")
            {
                textCardNumber.Text = "";
                textCardNumber.ForeColor = Color.Black;
            }
        }

        private void textDate_Enter(object sender, EventArgs e)
        {
            if (textDate.Text == "Date xx/xx")
            {
                textDate.Text = "";
                textDate.ForeColor = Color.Black;
            }
        }

        private void textCVC_Enter(object sender, EventArgs e)
        {
            if (textCVC.Text == "CVC code")
            {
                textCVC.Text = "";
                textCVC.ForeColor = Color.Black;
            }
        }

        private void textCardNumber_Leave(object sender, EventArgs e)
        {
            if (textCardNumber.Text == "")
            {
                textCardNumber.Text = "Card number";
                textCardNumber.ForeColor = Color.Gray;
            }
        }

        private void textDate_Leave(object sender, EventArgs e)
        {
            if (textDate.Text == "")
            {
                textDate.Text = "Date xx/xx";
                textDate.ForeColor = Color.Gray;
            }
        }

        private void textCVC_Leave(object sender, EventArgs e)
        {
            if (textCVC.Text == "")
            {
                textCVC.Text = "CVC code";
                textCVC.ForeColor = Color.Gray;
            }
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
