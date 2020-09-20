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
    public class CountryController : ControllerBase
    {

        private readonly PagilaContext _pagilaContext;  
        private readonly ILogger<CountryController> _logger;

        public CountryController(PagilaContext pagilaContext, ILogger<CountryController> logger) {  
            _pagilaContext = pagilaContext;  
            _logger = logger;
        }  
    
        [HttpGet]  
        public async Task <ActionResult<IEnumerable<Country>>> GetCountries() {  
            _logger.LogInformation("Fetching country list");
            return Ok(await _pagilaContext.Countries.ToListAsync());  
        }  
    }
}
