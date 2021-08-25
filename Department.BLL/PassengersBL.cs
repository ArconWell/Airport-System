using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class PassengersBL
    {
        private IPassengersDAO passengersDAO;

        public PassengersBL(IPassengersDAO passengersDAO)
        {
            this.passengersDAO = passengersDAO;
        }

        public IEnumerable<Passengers> GetPassengers()
        {
            return passengersDAO.GetPassengers();
        }

        public void AddPassenger(Passengers passenger)
        {
            passengersDAO.AddPassenger(passenger);
        }
        
        public void UpdatePassenger(Passengers passenger)
        {
            passengersDAO.UpdatePassenger(passenger);
        }

        public void DeletePassengers(Passengers passenger)
        {
            passengersDAO.DeletePassenger(passenger);
        }
    }
}
