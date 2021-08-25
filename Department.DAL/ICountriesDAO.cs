using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface ICountriesDAO
    {
        IEnumerable<Countries> GetCountries();
        void AddCountry(Countries country);
        void DeleteCountry(Countries country);
    }
}
