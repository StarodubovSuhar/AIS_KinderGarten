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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //monthCalendar1.Show();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //label4.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
            //monthCalendar1.Hide();
        }
    }
}
