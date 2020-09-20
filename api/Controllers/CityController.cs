using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {

        private readonly PagilaContext _pagilaContext;  
        private readonly ILogger<CityController> _logger;

        public CityController(PagilaContext pagilaContext, ILogger<CityController> logger) {  
            _pagilaContext = pagilaContext;  
            _logger = logger;
        }  
    
        [HttpGet]  
        public async Task <ActionResult<IEnumerable<Country>>> GetCityByCountryID(int country_id) {  
            _logger.LogInformation($"Fetching city {country_id}");
            return Ok(await _pagilaContext.Cities.Where(x => x.Country_ID == country_id).ToListAsync());  
        }  

    }
}
