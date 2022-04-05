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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attendance.ActiveForm.Hide();
            MainF Form = new MainF();
            Form.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendance.ActiveForm.Hide();
            Form5 Form = new Form5();
            Form.ShowDialog();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            db_connect conn = new db_connect();
            conn.openConnection();

            string sql = "SELECT * FROM attendance";

            MySqlCommand command = new MySqlCommand(sql, conn.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();
            conn.closeConnection();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void группаКраткосрочногоВремяПребыванияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void младшаяГруппаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            GetReportDay report = new GetReportDay();
            report.getWord(Date.ToString("d"), "Младшая группа");
            MessageBox.Show("Отчет за день успешно собран. Отчет сохранен в папке 'Мои документы'.", "Успешно");
        }
    }
}
