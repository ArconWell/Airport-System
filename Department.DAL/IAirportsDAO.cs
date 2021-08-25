using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IAirportsDAO
    {
        IEnumerable<Airports> GetAirports();
        void AddAirport(Airports airport);
        void UpdateAirport(Airports airport);
        void DeleteAirport(Airports airport);
    }
}
