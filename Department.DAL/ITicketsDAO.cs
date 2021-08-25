using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface ITicketsDAO
    {
        IEnumerable<Tickets> GetTickets();
        void AddTicket(Tickets ticket);
        void UpdateTicket(Tickets ticket);
        void DeleteTicket(Tickets ticket);
        void DiscountForBirthday();
    }
}
