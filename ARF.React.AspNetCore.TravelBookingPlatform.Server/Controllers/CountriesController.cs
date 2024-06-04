using Microsoft.AspNetCore.Mvc;
using ARF.Repository;
using ARF.DAL;

namespace ARF.React.AspNetCore.TravelBookingPlatform.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private iCountriesRepository _iCountriesRepo;  

        public CountriesController(iCountriesRepository countries)
        {
            _iCountriesRepo = countries;        

        }
        [HttpGet("COUNTRIES")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Models.Country>))]
        public IActionResult Index()
        {
            try
            {              
                List<Models.Country> countries = new List<Models.Country>();
                Models.Country boCountry = new Models.Country();              
                countries = _iCountriesRepo.GetAllCountries();               
                return Ok(countries);
            }
            catch (Exception ex)
            {                
                return StatusCode(303, $"Error in GetAllCountries : {ex.Message}");
            }
        }
    }
}
