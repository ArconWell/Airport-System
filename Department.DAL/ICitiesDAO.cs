using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface ICitiesDAO
    {
        IEnumerable<Cities> GetCities();
        void AddCity(Cities city);
        void UpdateCity(Cities city);
        void DeleteCity(Cities city);
    }
}
