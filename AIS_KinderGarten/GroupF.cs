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
using System.IO;
using MySql.Data.MySqlClient;

namespace КП
{
    public partial class GroupF : Form
    {
        public string NameF = "";
        public int count = 0;

        public GroupF(string NameForm)
        {
            NameF = NameForm;
            this.CenterToScreen();
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameF == "Младшая группа" && count < 20  || NameF == "Группа кратковременного пребывания" && count < 20)
            {
                GroupF.ActiveForm.Hide();
                AddChildrenF AddChildren = new AddChildrenF(NameF);
                AddChildren.ShowDialog();
                Close();
            }

            else if (NameF == "Средняя группа" && count < 25 || NameF == "Старшая группа" && count < 25 || NameF == "Подготовительная группа" && count < 25)
            {
                GroupF.ActiveForm.Hide();
                AddChildrenF AddChildren = new AddChildrenF(NameF);
                AddChildren.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Ошибка! В данной группе достигнут лимит воспитанников!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = NameF;

            db_connect conn = new db_connect();
            conn.openConnection();

            string sql = "SELECT * FROM pupils WHERE groups LIKE " + " '" + NameF + "'";

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

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
                count++;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             count = 0;
             GroupF.ActiveForm.Hide();
             GroupsF FName = new GroupsF();
             FName.ShowDialog();
             Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo);

            if (del == DialogResult.Yes)
            {
                string delete = "";

                int a = dataGridView1.CurrentRow.Index;
                var id = dataGridView1[0, a].Value;

                dataGridView1.Rows.Remove(dataGridView1.Rows[a]);

                delete = "DELETE FROM pupils WHERE id = " + id;

                db_connect conn = new db_connect();
                conn.openConnection();
                MySqlCommand command = new MySqlCommand(delete, conn.GetConnection());
                command.ExecuteNonQuery();
                conn.closeConnection();
                count--;
                MessageBox.Show("Вы успешно удалили воспитанника!", "Удаление");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            int ID = Convert.ToInt32(dataGridView1[0, a].Value);
            GroupF.ActiveForm.Hide();
            Form14 EditChildren = new Form14(NameF, ID);
            EditChildren.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupF.ActiveForm.Hide();
        }
    }
}
