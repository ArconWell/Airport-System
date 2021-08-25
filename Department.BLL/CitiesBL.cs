using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class CitiesBL
    {
        private ICitiesDAO citiesDAO;

        public CitiesBL(ICitiesDAO citiesDAO)
        {
            this.citiesDAO = citiesDAO;
        }

        public IEnumerable<Cities> GetCities()
        {
            return citiesDAO.GetCities();
        }

        public void AddCity(Cities city)
        {
            citiesDAO.AddCity(city);
        }

        public void UpdateCity(Cities city)
        {
            citiesDAO.UpdateCity(city);
        }

        public void DeleteCity(Cities city)
        {
            citiesDAO.DeleteCity(city);
        }
    }
}
