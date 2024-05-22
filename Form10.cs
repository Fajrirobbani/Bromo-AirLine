using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_AirLine
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form11 form = new Form11();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form9 j = new Form9();
            j.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
