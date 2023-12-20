using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus1
{
    public partial class Reg : Form
    {
        private DataBase db = new DataBase();
        public Reg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_log.Text; // Получение имени пользователя из TextBox
                string password = txt_pas.Text; // Получение пароля из TextBox
                int roleId = 2; // Предположим, что устанавливаем одну и ту же роль для всех пользователей

                // Вызов метода RegisterUser для добавления данных в базу данных
                db.RegisterUser(username, password, roleId);

                MessageBox.Show("Пользователь успешно зарегистрирован.");
                // После успешной регистрации закрываем текущую форму
                this.Close();

                // Открываем форму для входа/авторизации
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации пользователя: " + ex.Message);
            }
        }
    }
}
