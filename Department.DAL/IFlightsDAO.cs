using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IFlightsDAO
    {
        IEnumerable<Flights> GetFlights();
        void AddFlight(Flights flight);
        void UpdateFlight(Flights flight);
        void DeleteFlight(Flights flight);
    }
}
