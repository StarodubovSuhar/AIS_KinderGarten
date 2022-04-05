using db_project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace КП
{
    public partial class AuthF : Form
    {
        public AuthF()
        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txPassword.PasswordChar = '*';

            //string ln = InputLanguage.CurrentInputLanguage.LayoutName;

            //if (ln == "Русская")
            //{
            //    textBox1.Text = "RU";
            //}

            //else if (ln == "США")
            //{
            //    textBox1.Text = "EN";
            //}

            //else
            //{
            //    textBox1.Text = "";
            //}

            //if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Menu || e.KeyCode == Keys.ShiftKey)
            //{
            //    textBox1.Text = InputLanguage.CurrentInputLanguage.Culture.EnglishName.ToUpper();
            //}
        }

        public static string LogN = "";
        public static string LogF = "";
        public static string LogO = "";
        public static string Status = "";
        public static string Group = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txPassword.Text == "" && tbLogin.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните поля 'Логин' и 'Пароль'", "Ошибка");
            }

            else if (txPassword.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните поле 'Пароль'", "Ошибка");
            }

            else if (tbLogin.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните поле 'Логин'", "Ошибка");
            }

            else 
            {
                db_connect conn = new db_connect();

                conn.openConnection();

                string sql = "SELECT * FROM staff";

                MySqlCommand command = new MySqlCommand(sql, conn.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                bool flag = false;

                while (reader.Read())
                {
                    string LogP = reader[4].ToString();
                    LogN = reader[2].ToString();
                    LogF = reader[1].ToString();
                    LogO = reader[3].ToString();
                    Status = reader[7].ToString();
                    Group = reader[6].ToString();
                    string Logins = tbLogin.Text;
                    string Pass = txPassword.Text;
                    string[] Log = Logins.Split(new string[] { " " }, StringSplitOptions.None);

                    if (Log[0] == LogF && Log[1] == LogN && Pass == LogP)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == true)
                {
                    MessageBox.Show("Вы успешно вошли под пользователем: " + LogF + " " + LogN + "." + " Добро пожаловать!", "Авторизация");

                    AuthF.ActiveForm.Hide();
                    MainF Main = new MainF();
                    Main.ShowDialog();
                    Close();
                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль! Если Вы забыли пароль, обратитесь к Администратору для восстановления.", "Авторизация");
                }

                reader.Close();
                conn.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("RU"));
            textBox1.Text = InputLanguage.CurrentInputLanguage.ToString();
        }

        private void txPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'Z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }

            else
            {
                MessageBox.Show("Ошибка! Некорректный символ. Проверьте раскладку.", "Ошибка");
                e.Handled = true;
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                MessageBox.Show("Ошибка! Некорректный символ. Проверьте раскладку.", "Ошибка");
                e.Handled = true;
            }
        }
    }
}
