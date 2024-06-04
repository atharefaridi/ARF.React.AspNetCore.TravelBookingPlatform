using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARF.Models;

namespace ARF.Repository
{
    public interface iCountriesRepository
    {
        Country GetByID(string id);
        List<Country> GetAllCountries();
        void Update(Country country);
        void Add(Country country);
    }
}
