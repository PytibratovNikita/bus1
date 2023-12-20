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

namespace bus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            txtPassword.MaxLength = 50;
            txtUsername.MaxLength = 50;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Строка подключения к базе данных BUS на сервере HOME-PC
            string connectionString = "Server=HOME-PC;Database=BUS;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Запрос для проверки данных входа пользователя
                string query = "SELECT * FROM Accounts WHERE Username = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));

                    if (roleID == 1) // Предположим, что 1 - ID роли администратора
                    {
                        MessageBox.Show("Вы вошли как администратор");
                        // Запускаем форму администратора или выполняем действия для администратора
                    }
                    else if (roleID == 2) // Предположим, что 2 - ID роли пользователя
                    {
                        MessageBox.Show("Вы вошли как пользователь");
                        // Запускаем форму пользователя или выполняем действия для пользователя
                    }
                }
                if (reader.HasRows)
                {
                        int roleID = reader.GetInt32(reader.GetOrdinal("RoleID"));

                        if (roleID == 1)
                        {
                            Console.WriteLine("Открываем форму администратора");
                            // Открываем форму администратора
                            Form2Admin form2Admin = new Form2Admin();
                            form2Admin.Show();

                            this.Hide();
                        }
                        else if (roleID == 2)
                        {
                            MessageBox.Show("Вы вошли как пользователь");
                            Console.WriteLine("Открываем форму пользователя");
                            // Открываем форму пользователя
                            Form2User form2User = new Form2User();
                            form2User.Show();

                            this.Hide();
                        }

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            button2.Visible = true;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            button2.Visible = false;
            button3.Visible = true;
        }
    }
}
