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
    public class TicketsSQLDAO : ITicketsDAO
    {
        public void AddTicket(Tickets ticket)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "AddTicket";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@document", string.IsNullOrEmpty(ticket.Document) ? Convert.DBNull : ticket.Document);
                    command.Parameters.AddWithValue("@flight", ticket.Flight);
                    command.Parameters.AddWithValue("@seatNumber", string.IsNullOrEmpty(ticket.SeatNumber) ? Convert.DBNull : ticket.SeatNumber);
                    command.Parameters.AddWithValue("@cost", ticket.Cost);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteTicket(Tickets ticket)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DeleteTicket";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ticketNumber", ticket.TicketNumber);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DiscountForBirthday()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "DiscointForBirthday";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<Tickets> GetTickets()
        {
            List<Tickets> tickets = new List<Tickets>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetTickets";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Tickets ticket = new Tickets(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3),
                            reader.GetDecimal(4));
                        tickets.Add(ticket);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return tickets;
        }

        public void UpdateTicket(Tickets ticket)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UpdateTicket";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ticketNumber", ticket.TicketNumber);
                    command.Parameters.AddWithValue("@document", string.IsNullOrEmpty(ticket.Document) ? Convert.DBNull : ticket.Document);
                    command.Parameters.AddWithValue("@flight", ticket.Flight);
                    command.Parameters.AddWithValue("@seatNumber", string.IsNullOrEmpty(ticket.SeatNumber) ? Convert.DBNull : ticket.SeatNumber);
                    command.Parameters.AddWithValue("@cost", ticket.Cost);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
