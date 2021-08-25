using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class AirplanesSQLDAO : IAirplanesDAO
    {
        public void AddAirplane(Airplanes airplane)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddAirplane";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@airplaneNumber", string.IsNullOrEmpty(airplane.AirplaneNumber) ? Convert.DBNull : airplane.AirplaneNumber);
                    command.Parameters.AddWithValue("@airplaneName", string.IsNullOrEmpty(airplane.AirplaneName) ? Convert.DBNull : airplane.AirplaneName);
                    command.Parameters.AddWithValue("@airline", string.IsNullOrEmpty(airplane.Airline) ? Convert.DBNull : airplane.Airline);
                    command.Parameters.AddWithValue("@seatsCount", airplane.SeatsCount);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteAirplane(Airplanes airplane)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteAirplane";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@airplaneNumber", airplane.AirplaneName);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Airplanes> GetAirplanes()
        {
            List<Airplanes> airplanes = new List<Airplanes>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetAirplanes";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Airplanes airplane = new Airplanes(reader.GetString(0),
                            reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                        airplanes.Add(airplane);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return airplanes;
        }

        public void UpdateAirplane(Airplanes airplane)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateAirplane";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@airplaneNumber", string.IsNullOrEmpty(airplane.AirplaneNumber) ? Convert.DBNull : airplane.AirplaneNumber);
                    command.Parameters.AddWithValue("@airplaneName", string.IsNullOrEmpty(airplane.AirplaneName) ? Convert.DBNull : airplane.AirplaneName);
                    command.Parameters.AddWithValue("@airline", string.IsNullOrEmpty(airplane.Airline) ? Convert.DBNull : airplane.Airline);
                    command.Parameters.AddWithValue("@seatsCount", airplane.SeatsCount);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
