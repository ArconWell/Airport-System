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
    public class FlightsSQLDAO : IFlightsDAO
    {
        public void AddFlight(Flights flight)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddFlight";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@airplaneNumber", string.IsNullOrEmpty(flight.AirplaneNumber) ? Convert.DBNull : flight.AirplaneNumber);
                    command.Parameters.AddWithValue("@departureAirport", string.IsNullOrEmpty(flight.DepartureAirport) ? Convert.DBNull : flight.DepartureAirport);
                    command.Parameters.AddWithValue("@arrivalAirport", string.IsNullOrEmpty(flight.ArrivalAirport) ? Convert.DBNull : flight.ArrivalAirport);
                    command.Parameters.AddWithValue("@departureDateTime", flight.DepartureDateTime);
                    command.Parameters.AddWithValue("@arrivalDateTime", flight.ArrivalDateTime);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteFlight(Flights flight)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteFlight";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@flightNumber", flight.FlightNumber);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Flights> GetFlights()
        {
            List<Entities.Flights> flights = new List<Flights>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetFlights";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Flights flight= new Flights(reader.GetInt32(0),
                            reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5));
                        flights.Add(flight);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return flights;
        }

        public void UpdateFlight(Flights flight)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateFlight";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
                    command.Parameters.AddWithValue("@airplaneNumber", string.IsNullOrEmpty(flight.AirplaneNumber) ? Convert.DBNull : flight.AirplaneNumber);
                    command.Parameters.AddWithValue("@departureAirport", string.IsNullOrEmpty(flight.DepartureAirport) ? Convert.DBNull : flight.DepartureAirport);
                    command.Parameters.AddWithValue("@arrivalAirport", string.IsNullOrEmpty(flight.ArrivalAirport) ? Convert.DBNull : flight.ArrivalAirport);
                    command.Parameters.AddWithValue("@departureDateTime", flight.DepartureDateTime);
                    command.Parameters.AddWithValue("@arrivalDateTime", flight.ArrivalDateTime);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
