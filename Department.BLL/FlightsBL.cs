using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class FlightsBL
    {
        private IFlightsDAO flightsDAO;

        public FlightsBL(IFlightsDAO flightsDAO)
        {
            this.flightsDAO = flightsDAO;
        }

        public IEnumerable<Flights> GetFlights()
        {
            return flightsDAO.GetFlights();
        }

        public void AddFlight(Flights flight)
        {
            flightsDAO.AddFlight(flight);
        }

        public void UpdateFlight(Flights flight)
        {
            flightsDAO.UpdateFlight(flight);
        }

        public void DeleteFlight(Flights flight)
        {
            flightsDAO.DeleteFlight(flight);
        }
    }
}
