using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class TicketsBL
    {
        private ITicketsDAO ticketsDAO;

        public TicketsBL(ITicketsDAO ticketsDAO)
        {
            this.ticketsDAO = ticketsDAO;
        }

        public IEnumerable<Tickets> GetTickets()
        {
            return ticketsDAO.GetTickets();
        }

        public void AddTicket(Tickets ticket)
        {
            ticketsDAO.AddTicket(ticket);
        }

        public void UpdateTicket(Tickets ticket)
        {
            ticketsDAO.UpdateTicket(ticket);
        }

        public void DeleteTicket(Tickets ticket)
        {
            ticketsDAO.DeleteTicket(ticket);
        }

        public void DiscountForBirthday()
        {
            ticketsDAO.DiscountForBirthday();
        }
    }
}
