using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class AirportsBL
    {
        private IAirportsDAO airportsDAO;

        public AirportsBL(IAirportsDAO airportsDAO)
        {
            this.airportsDAO = airportsDAO;
        }

        public IEnumerable<Airports> GetAirports()
        {
            return airportsDAO.GetAirports();
        }

        public void AddAirport(Airports airport)
        {
            airportsDAO.AddAirport(airport);
        }

        public void UpdateAirport(Airports airport)
        {
            airportsDAO.UpdateAirport(airport);
        }

        public void DeleteAirport(Airports airport)
        {
            airportsDAO.DeleteAirport(airport);
        }
    }
}
