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
    public partial class Form2Admin : Form
    {
        private DataBase db = new DataBase();
        public Form2Admin()
        {
            InitializeComponent();
            distanceNumericUpDown.Minimum = 0; // Минимальное значение расстояния
            distanceNumericUpDown.Maximum = 1000; // Максимальное значение расстояния
            distanceNumericUpDown.Value = 0; // Начальное значение расстояния
            distanceNumericUpDown.DecimalPlaces = 2; // Количество десятичных знаков

            travelTimeNumericUpDown.Minimum = 0; // Минимальное значение времени в пути
            travelTimeNumericUpDown.Maximum = 24 * 60; // Максимальное значение времени в пути (в минутах), например, 24 часа
            travelTimeNumericUpDown.Value = 0; // Начальное значение времени в пути

            fareNumericUpDown.Minimum = 0; // Минимальная стоимость проезда
            fareNumericUpDown.Maximum = 1000; // Максимальная стоимость проезда
            fareNumericUpDown.Value = 0; // Начальная стоимость проезда
            fareNumericUpDown.DecimalPlaces = 2; // Количество десятичных знаков
        }

        private void Form2Admin_Load(object sender, EventArgs e)
        {
        }
        private void LoadRoutes()
        {
            
        }

        private void маршрутыBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string departure = departureTextBox.Text; // Получение пункта отправления из TextBox
                string destination = destinationTextBox.Text; // Получение пункта назначения из TextBox
                double distance = Convert.ToDouble(distanceNumericUpDown.Value); // Получение расстояния из NumericUpDown
                int travelTime = Convert.ToInt32(travelTimeNumericUpDown.Value); // Получение времени в пути из NumericUpDown
                decimal fare = fareNumericUpDown.Value; // Получение стоимости проезда из NumericUpDown

                // Вызов метода AddRoute для добавления данных в базу данных
                db.AddRoute(departure, destination, distance, travelTime, fare);

                MessageBox.Show("Маршрут успешно добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении маршрута: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            // Очистка значений элементов управления после добавления маршрута
            departureTextBox.Text = "";
            destinationTextBox.Text = "";
            distanceNumericUpDown.Value = 0;
            travelTimeNumericUpDown.Value = 0;
            fareNumericUpDown.Value = 0;
        }

        private void travelTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
