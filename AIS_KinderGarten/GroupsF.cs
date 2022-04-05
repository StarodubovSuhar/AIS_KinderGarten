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
    public partial class GroupsF : Form
    {
        public GroupsF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthF.Group == "Группа кратковременного пребывания" || AuthF.Status == "Администратор")
            {
                GroupsF.ActiveForm.Hide();
                string NameForm = "Группа кратковременного пребывания";
                GroupF Groups = new GroupF(NameForm);
                Groups.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вы не имеете доступа к данному разделу.","Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AuthF.Group == "Младшая группа" || AuthF.Status == "Администратор")
            {
                GroupsF.ActiveForm.Hide();
                string NameForm = "Младшая группа";
                GroupF Groups = new GroupF(NameForm);
                Groups.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вы не имеете доступа к данному разделу.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AuthF.Group == "Средняя группа" || AuthF.Status == "Администратор")
            {
                GroupsF.ActiveForm.Hide();
                string NameForm = "Средняя группа";
                GroupF Groups = new GroupF(NameForm);
                Groups.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вы не имеете доступа к данному разделу.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AuthF.Group == "Старшая группа" || AuthF.Status == "Администратор")
            {
                GroupsF.ActiveForm.Hide();
                string NameForm = "Старшая группа";
                GroupF Groups = new GroupF(NameForm);
                Groups.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вы не имеете доступа к данному разделу.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AuthF.Group == "Подготовительная группа" || AuthF.Status == "Администратор")
            {
                GroupsF.ActiveForm.Hide();
                string NameForm = "Подготовительная группа";
                GroupF Groups = new GroupF(NameForm);
                Groups.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Вы не имеете доступа к данному разделу.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GroupsF.ActiveForm.Hide();
            MainF G = new MainF();
            G.ShowDialog();
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
