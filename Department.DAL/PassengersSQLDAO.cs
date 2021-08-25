using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Department.DAL
{
    public class PassengersSQLDAO : IPassengersDAO
    {
        public void AddPassenger(Passengers passenger)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddPassenger";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@surname", string.IsNullOrEmpty(passenger.Surname) ? Convert.DBNull : passenger.Surname);
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(passenger.Name) ? Convert.DBNull : passenger.Name);
                    command.Parameters.AddWithValue("@patronymic", string.IsNullOrEmpty(passenger.Patronymic) ? Convert.DBNull :
                        passenger.Patronymic);
                    command.Parameters.AddWithValue("@dateOfBirth", passenger.DateOfBirth);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeletePassenger(Passengers passenger)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeletePassenger";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID", passenger.Id);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Passengers> GetPassengers()
        {
            List<Passengers> passengers = new List<Passengers>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetPassengers";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Passengers passenger = new Passengers(reader.GetInt32(0), reader.GetDateTime(4),
                            reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        passengers.Add(passenger);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return passengers;
        }

        public void UpdatePassenger(Passengers passenger)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdatePassenger";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID", passenger.Id);
                    command.Parameters.AddWithValue("@surname", string.IsNullOrEmpty(passenger.Surname) ? Convert.DBNull : passenger.Surname);
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(passenger.Name) ? Convert.DBNull : passenger.Name);
                    command.Parameters.AddWithValue("@patronymic", string.IsNullOrEmpty(passenger.Patronymic) ? Convert.DBNull :
                        passenger.Patronymic);
                    command.Parameters.AddWithValue("@dateOfBirth", passenger.DateOfBirth);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
