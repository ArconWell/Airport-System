using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Flights
    {
        private int flightNumber;
        private string airplaneNumber, departureAirport, arrivalAirport;
        private DateTime departureDateTime, arrivalDateTime;

        public int FlightNumber { get => flightNumber; set => flightNumber = value; }
        public string AirplaneNumber { get => airplaneNumber; set => airplaneNumber = value; }
        public string DepartureAirport { get => departureAirport; set => departureAirport = value; }
        public string ArrivalAirport { get => arrivalAirport; set => arrivalAirport = value; }
        public DateTime DepartureDateTime { get => departureDateTime; set => departureDateTime = value; }
        public DateTime ArrivalDateTime { get => arrivalDateTime; set => arrivalDateTime = value; }

        public Flights(int flightNumber, string airplaneNumber, string departureAirport, string arrivalAirport, 
            DateTime departureDateTime, DateTime arrivalDateTime)
        {
            this.flightNumber = flightNumber;
            this.airplaneNumber = airplaneNumber ?? throw new ArgumentNullException(nameof(airplaneNumber));
            this.departureAirport = departureAirport ?? throw new ArgumentNullException(nameof(departureAirport));
            this.arrivalAirport = arrivalAirport ?? throw new ArgumentNullException(nameof(arrivalAirport));
            this.departureDateTime = departureDateTime;
            this.arrivalDateTime = arrivalDateTime;
        }
    }
}
