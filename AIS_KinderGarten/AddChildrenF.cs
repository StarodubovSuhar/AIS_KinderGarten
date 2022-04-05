using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using db_project;
using MySql.Data.MySqlClient;

namespace КП
{
    public partial class AddChildrenF : Form
    {
        string FormName;
        public AddChildrenF(string NameF)
        {
            FormName = NameF;
            this.CenterToScreen();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddChildrenF.ActiveForm.Hide();
            GroupF AddChildren = new GroupF(FormName);
            AddChildren.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || label6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Вы не заполнили поля. Заполните все поля!", "Ошибка");
            }

            else 
            {
                db_connect conn = new db_connect();

                conn.openConnection();

                string query = "INSERT INTO pupils (id, last_name, name, three_name, date_born, groups) VALUES (null, @Фамилия, @Имя, @Отчество, @Дата, @Группа)";

                MySqlCommand command = new MySqlCommand(query, conn.GetConnection());

                command.Parameters.AddWithValue("@Фамилия", textBox1.Text);
                command.Parameters.AddWithValue("@Имя", textBox2.Text);
                command.Parameters.AddWithValue("@Отчество", textBox3.Text);
                command.Parameters.AddWithValue("@Дата", label6.Text);
                command.Parameters.AddWithValue("@Группа", comboBox1.Text);

                command.ExecuteNonQuery();

                conn.closeConnection();

                GroupF f = new GroupF(FormName);
                f.count++;

                MessageBox.Show("Вы успешно добавили нового воспитанника!", "Добавление");
            }

        }

        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        { 
            if (flag == false)
            {
                monthCalendar1.Visible = true;
                flag = true;
                button1.Text = "Сохранить дату рождения"; 
            }

            else
            {
                monthCalendar1.Visible = false;
                flag = false;
                button1.Text = "Выбрать дату рождения"; 
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            label6.Text = e.End.ToString("dd/MM/yyyy");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
