using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Countries
    {
        private string country;

        public string Country { get => country; set => country = value; }

        public Countries(string country)
        {
            this.country = country ?? throw new ArgumentNullException(nameof(country));
        }
    }
}
