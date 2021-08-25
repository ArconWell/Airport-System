using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Airlines
    {
        private string name, country;

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }

        public Airlines(string name, string country)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.country = country ?? throw new ArgumentNullException(nameof(country));
        }
    }
}
