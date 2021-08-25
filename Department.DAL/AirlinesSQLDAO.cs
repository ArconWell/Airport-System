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
    public class AirlinesSQLDAO : IAirlinesDAO
    {
        public void AddAirline(Airlines airline)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddAirline";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(airline.Name) ? Convert.DBNull : airline.Name);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(airline.Country) ? Convert.DBNull : airline.Country);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteAirline(Airlines airline)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteAirline";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@name", airline.Name);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Airlines> GetAirlines()
        {
            List<Airlines> airlines = new List<Airlines>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetAirlines";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Airlines airline = new Airlines(reader.GetString(0), reader.GetString(1));
                        airlines.Add(airline);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return airlines;
        }

        public void UpdateAirline(Airlines airline)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateAirline";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(airline.Name) ? Convert.DBNull : airline.Name);
                    command.Parameters.AddWithValue("@country", string.IsNullOrEmpty(airline.Country) ? Convert.DBNull : airline.Country);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
