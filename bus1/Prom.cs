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
    public partial class Prom : Form
    {
        public Prom()
        {
            InitializeComponent();
        }

        private void Prom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bUSDataSet3.Intermediate_points". При необходимости она может быть перемещена или удалена.
            this.intermediate_pointsTableAdapter.Fill(this.bUSDataSet3.Intermediate_points);

        }

        private void returnButton3_Click(object sender, EventArgs e)
        {
            Form2User form2User = new Form2User();

            // Отображение формы Form2User
            form2User.Show();

            // Закрытие текущей формы
            this.Close();
        }
    }
}
