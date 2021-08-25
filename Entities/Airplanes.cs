using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Airplanes
    {
        private string airplaneNumber, airplaneName, airline;
        private int seatsCount;

        public string AirplaneNumber { get => airplaneNumber; set => airplaneNumber = value; }
        public string AirplaneName { get => airplaneName; set => airplaneName = value; }
        public string Airline { get => airline; set => airline = value; }
        public int SeatsCount { get => seatsCount; set => seatsCount = value; }

        public Airplanes(string airplaneNumber, string airplaneName, string airline, int seatsCount)
        {
            this.airplaneNumber = airplaneNumber ?? throw new ArgumentNullException(nameof(airplaneNumber));
            this.airplaneName = airplaneName ?? throw new ArgumentNullException(nameof(airplaneName));
            this.airline = airline ?? throw new ArgumentNullException(nameof(airline));
            this.seatsCount = seatsCount;
        }
    }
}
