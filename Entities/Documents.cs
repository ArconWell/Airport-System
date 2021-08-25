using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Documents
    {
        private string documentNumber, documentType, country;
        private int ownerId;

        public string DocumentNumber { get => documentNumber; set => documentNumber = value; }
        public string DocumentType { get => documentType; set => documentType = value; }
        public string Country { get => country; set => country = value; }
        public int OwnerId { get => ownerId; set => ownerId = value; }

        public Documents(string documentNumber, string documentType, string country, int ownerId)
        {
            this.documentNumber = documentNumber ?? throw new ArgumentNullException(nameof(documentNumber));
            this.documentType = documentType ?? throw new ArgumentNullException(nameof(documentType));
            this.country = country ?? throw new ArgumentNullException(nameof(country));
            this.ownerId = ownerId;
        }
    }
}
