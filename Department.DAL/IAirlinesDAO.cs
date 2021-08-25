using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IAirlinesDAO
    {
        IEnumerable<Airlines> GetAirlines();
        void AddAirline(Airlines airline);
        void UpdateAirline(Airlines airline);
        void DeleteAirline(Airlines airline);
    }

}
