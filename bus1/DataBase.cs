using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace bus1
{
    class DataBase
    {
        private string connectionString = "Data Source=HOME-PC;Initial Catalog=BUS;Integrated Security=True"; // Замените на вашу строку подключения к базе данных

        public void RegisterUser(string username, string password, int roleId)
        {
            string query = "INSERT INTO Accounts (Username, Password, RoleID) " +
                           "VALUES (@Username, @Password, @RoleID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@RoleID", roleId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Пользователь успешно зарегистрирован.");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось зарегистрировать пользователя.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка при регистрации пользователя: " + ex.Message);
                    }
                }
            }
        }
        public void AddRoute(string departure, string destination, double distance, int travelTime, decimal fare)
        {
            string query = "INSERT INTO Routes (пункт_отправления, пункт_назначения, расстояние, время_в_пути, стоимость_проезда) " +
                           "VALUES (@Departure, @Destination, @Distance, @TravelTime, @Fare)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Departure", departure);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@Distance", distance);   
                    command.Parameters.AddWithValue("@TravelTime", travelTime);
                    command.Parameters.AddWithValue("@Fare", fare);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Маршрут успешно добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось добавить маршрут.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка при добавлении маршрута: " + ex.Message);
                    }
                }
            }
        }
    }
}

