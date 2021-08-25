using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IPassengersDAO
    {
        IEnumerable<Entities.Passengers> GetPassengers();
        void AddPassenger(Passengers passenger);
        void UpdatePassenger(Passengers passenger);
        void DeletePassenger(Passengers passenger);
    }
}
