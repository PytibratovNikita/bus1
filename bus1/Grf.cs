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
    public partial class Grf : Form
    {
        public Grf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grf_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bUSDataSet3.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.bUSDataSet3.Schedule);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2User form2User = new Form2User();

            // Отображение формы Form2User
            form2User.Show();

            // Закрытие текущей формы
            this.Close();
        }
    }
}
