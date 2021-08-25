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
    public class AirportsSQLDAO : IAirportsDAO
    {
        public void AddAirport(Airports airport)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddAirport";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@code", string.IsNullOrEmpty(airport.Code) ? Convert.DBNull : airport.Code);
                    command.Parameters.AddWithValue("@airportName", string.IsNullOrEmpty(airport.AirportName) ? Convert.DBNull : airport.AirportName);
                    command.Parameters.AddWithValue("@cityId", airport.CityId);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteAirport(Airports airport)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteAirport";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@code", airport.Code);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Airports> GetAirports()
        {
            List<Airports> airports = new List<Airports>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetAirports";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Airports airport = new Airports(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                        airports.Add(airport);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return airports;
        }

        public void UpdateAirport(Airports airport)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateAirport";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@code", string.IsNullOrEmpty(airport.Code) ? Convert.DBNull : airport.Code);
                    command.Parameters.AddWithValue("@airportName", string.IsNullOrEmpty(airport.AirportName) ? Convert.DBNull : airport.AirportName);
                    command.Parameters.AddWithValue("@cityId", airport.CityId);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
