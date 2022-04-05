using db_project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        bool flag = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                monthCalendar1.Visible = true;
                flag = true;
                button2.Text = "Сохранить дату отсутствия";
            }

            else
            {
                monthCalendar1.Visible = false;
                flag = false;
                button2.Text = "Выбрать дату отсутствия";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Attendance Form = new Attendance();
            Form.ShowDialog();
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label7.Text = e.End.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_connect conn = new db_connect();

            conn.openConnection();

            string query = "INSERT INTO attendance (id, last_name, name, three_name, reason, date) VALUES (null, @Фамилия, @Имя, @Отчество, @Пропуск, @Дата)";

            MySqlCommand command = new MySqlCommand(query, conn.GetConnection());

            command.Parameters.AddWithValue("@Фамилия", textBox1.Text);
            command.Parameters.AddWithValue("@Имя", textBox2.Text);
            command.Parameters.AddWithValue("@Отчество", textBox3.Text);
            command.Parameters.AddWithValue("@Пропуск", textBox4.Text);
            command.Parameters.AddWithValue("@Дата", label7.Text);

            command.ExecuteNonQuery();

            conn.closeConnection();

            MessageBox.Show("Вы успешно добавили пропуск воспитанника!", "Добавление");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
