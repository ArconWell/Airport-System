using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class AirplanesBL
    {
        private IAirplanesDAO airplanesDAO;

        public AirplanesBL(IAirplanesDAO airplanesDAO)
        {
            this.airplanesDAO = airplanesDAO;
        }

        public IEnumerable<Airplanes> GetAirplanes()
        {
            return airplanesDAO.GetAirplanes();
        }

        public void AddAirplane(Airplanes airplane)
        {
            airplanesDAO.AddAirplane(airplane);
        }

        public void UpdateAirplane(Airplanes airplane)
        {
            airplanesDAO.UpdateAirplane(airplane);
        }

        public void DeleteAirplane(Airplanes airplane)
        {
            airplanesDAO.DeleteAirplane(airplane);
        }
    }
}
