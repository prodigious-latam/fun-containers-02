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
    
        public CountryController(PagilaContext pagilaContext) {  
            _pagilaContext = pagilaContext;  
        }  
    
        [HttpGet]  
        public async Task <ActionResult<IEnumerable<Country>>> GetCountries() {  
            return Ok(await _pagilaContext.Countries.ToListAsync());  
        }  
    }
}
