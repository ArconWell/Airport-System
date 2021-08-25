using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class AirlinesBL
    {
        private IAirlinesDAO airlinesDAO;

        public AirlinesBL(IAirlinesDAO airlinesDAO)
        {
            this.airlinesDAO = airlinesDAO;
        }

        public IEnumerable<Airlines> GetAirlines()
        {
            return airlinesDAO.GetAirlines();
        }

        public void AddAirline(Airlines airline)
        {
            airlinesDAO.AddAirline(airline);
        }

        public void UpdateAirline(Airlines airline)
        {
            airlinesDAO.UpdateAirline(airline);
        }

        public void DeleteAirline(Airlines airline)
        {
            airlinesDAO.DeleteAirline(airline);
        }
    }
}
