using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus1
{
    public partial class Form2User : Form
    {
        public Form2User()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mar mar = new Mar();
            mar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grf grf = new Grf();
            grf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prom prm = new Prom();
            prm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
