using ARF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARF.DAL
{
    public class Countries
    {
        public List<Country> GetAllCountries()
        {
            List<Country> countries =
            [
                new Country
                {
                    id = "1",
                    name = "India",
                    language = "Urdu",
                    alpha2Code = "In",
                    currency = "RS"

                },
                new Country
                {
                    id = "2",
                    name = "Singapore",
                    language = "English",
                    alpha2Code = "Sg",
                    currency = "SGD"

                },
                new Country
                {
                    id = "3",
                    name = "Malaysia",
                    language = "Malay",
                    alpha2Code = "My",
                    currency = "MYR"

                },
                new Country
                {
                    id = "4",
                    name = "Portugal",
                    language = "Portuguese",
                    alpha2Code = "Pt",
                    currency = "Euro"

                },
            ];            


            return countries;
        }

        public void Add(Country country)
        {
            throw new NotImplementedException();
        }

        public Country GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Country country)
        {
            throw new NotImplementedException();
        }
    }
}
