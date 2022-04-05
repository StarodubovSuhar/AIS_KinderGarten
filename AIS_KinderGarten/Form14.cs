using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using db_project;
using MySql.Data.MySqlClient;

namespace КП
{
    public partial class Form14 : Form
    {
        string FormName;
        int id;
        public Form14(string NameF, int ID)
        {
            FormName = NameF;
            id = ID;
            this.CenterToScreen();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            db_connect conn = new db_connect();
            conn.openConnection();

            string sql = "SELECT * FROM pupils WHERE id = " + id;

            MySqlCommand command = new MySqlCommand(sql, conn.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            conn.closeConnection();

            textBox1.Text = data[data.Count - 1][1];
            textBox2.Text = data[data.Count - 1][2];
            textBox3.Text = data[data.Count - 1][3];
            label6.Text = data[data.Count - 1][4];
            comboBox1.Text = data[data.Count - 1][5];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14.ActiveForm.Hide();
            GroupF AddChildren = new GroupF(FormName);
            AddChildren.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db_connect conn = new db_connect();

            conn.openConnection();

            string query = "UPDATE pupils SET id=" + id + ", last_name=@Фамилия, name=@Имя, three_name=@Отчество, date_born=@Дата, groups=@Группа WHERE id = " + id;

            MySqlCommand command = new MySqlCommand(query, conn.GetConnection());

            command.Parameters.AddWithValue("@Фамилия", textBox1.Text);
            command.Parameters.AddWithValue("@Имя", textBox2.Text);
            command.Parameters.AddWithValue("@Отчество", textBox3.Text);
            command.Parameters.AddWithValue("@Дата", label6.Text);
            command.Parameters.AddWithValue("@Группа", comboBox1.Text);

            command.ExecuteNonQuery();

            conn.closeConnection();

            MessageBox.Show("Вы успешно отредактировали информацию о воспитаннике!", "Редактирование");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label6.Text = e.End.ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }
    }
}
