using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cities
    {
        private int id;
        private string city, country;

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public Cities(int id, string city, string country)
        {
            this.id = id;
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.country = country ?? throw new ArgumentNullException(nameof(country));
        }
    }
}
