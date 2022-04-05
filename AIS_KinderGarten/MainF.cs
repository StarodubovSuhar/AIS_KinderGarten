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
using db_project;

namespace КП
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
            
            if (AuthF.Status == "Администратор")
            {
                label1.Text = "Вы зашли как: " + AuthF.LogF + " " + AuthF.LogN + " " + AuthF.LogO + " (" + AuthF.Status + ")";
            }

            else
            {
                label1.Text = "Вы зашли как: " + AuthF.LogF + " " + AuthF.LogN + " " + AuthF.LogO;
            }

            timer1.Start();
        }

        //public Form1()
        //{
        //    // TODO: Complete member initialization
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult g = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (g == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            label2.Text = "Сегодня: " + Date.ToString("D") + Date.ToString("T");
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            MainF.ActiveForm.Hide();
            GroupsF GroupForm = new GroupsF();
            GroupForm.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AuthF.Status == "Администратор")
            {
                DialogResult ds = MessageBox.Show("Вы действительно хотите сделать резервное копирование базы данных?", "Резервное копирование", MessageBoxButtons.YesNo);

                if (ds == DialogResult.Yes)
                {
                    Backup bk = new Backup();
                    bk.getBackup();
                    MessageBox.Show("Резервное копирование базы данных сделано успешно!", "Резервное копирование");
                }
            }

            else
            {
                MessageBox.Show("Вам не доступен этот раздел. Если произошла ошибка обратитесь к Администратору.", "Резервное копирование");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AuthF.Status == "Администратор")
            {
                MainF.ActiveForm.Hide();
                Staff Form = new Staff();
                Form.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вам не доступен этот раздел. Если произошла ошибка обратитесь к Администратору.", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainF.ActiveForm.Hide();
            Attendance Form = new Attendance();
            Form.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
