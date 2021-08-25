using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class CountriesBL
    {
        private ICountriesDAO countriesDAO;

        public CountriesBL(ICountriesDAO countriesDAO)
        {
            this.countriesDAO = countriesDAO;
        }

        public IEnumerable<Countries> GetCountries()
        {
            return countriesDAO.GetCountries();
        }

        public void AddCountry(Countries country)
        {
            countriesDAO.AddCountry(country);
        }

        public void DeleteCountry(Countries country)
        {
            countriesDAO.DeleteCountry(country);
        }
    }
}
