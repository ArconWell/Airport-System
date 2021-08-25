using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Airports
    {
        private string code, airportName;
        private int cityId;

        public string Code { get => code; set => code = value; }
        public string AirportName { get => airportName; set => airportName = value; }
        public int CityId { get => cityId; set => cityId = value; }

        public Airports(string code, string airportName, int cityId)
        {
            this.code = code ?? throw new ArgumentNullException(nameof(code));
            this.airportName = airportName ?? throw new ArgumentNullException(nameof(airportName));
            this.cityId = cityId;
        }
    }
}
