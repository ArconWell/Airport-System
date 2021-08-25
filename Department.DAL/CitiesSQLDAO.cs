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
    public class CitiesSQLDAO : ICitiesDAO
    {
        public void AddCity(Cities city)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddCity";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@city", string.IsNullOrEmpty(city.City) ? Convert.DBNull : city.City);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(city.Country) ? Convert.DBNull : city.Country);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteCity(Cities city)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteCity";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID", city.Id);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Cities> GetCities()
        {
            List<Entities.Cities> cities = new List<Cities>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetCities";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cities city = new Cities(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        cities.Add(city);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return cities;
        }

        public void UpdateCity(Cities city)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateCity";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID", city.Id);
                    command.Parameters.AddWithValue("@city", string.IsNullOrEmpty(city.City) ? Convert.DBNull : city.City);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(city.Country) ? Convert.DBNull : city.Country);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
