using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IAirplanesDAO
    {
        IEnumerable<Airplanes> GetAirplanes();
        void AddAirplane(Airplanes airplane);
        void UpdateAirplane(Airplanes airplane);
        void DeleteAirplane(Airplanes airplane);
    }
}
