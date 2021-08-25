using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tickets
    {
        private int ticketNumber;
        private string document;
        private int flight;
        private string seatNumber;
        private decimal cost;

        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public string Document { get => document; set => document = value; }
        public int Flight { get => flight; set => flight = value; }
        public string SeatNumber { get => seatNumber; set => seatNumber = value; }
        public decimal Cost { get => cost; set => cost = value; }

        public Tickets(int ticketNumber, string document, int flight, string seatNumber, decimal cost)
        {
            this.ticketNumber = ticketNumber;
            this.document = document ?? throw new ArgumentNullException(nameof(document));
            this.flight = flight;
            this.seatNumber = seatNumber ?? throw new ArgumentNullException(nameof(seatNumber));
            this.cost = cost;
        }
    }
}
