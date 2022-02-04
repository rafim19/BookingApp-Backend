using Binus.WS.Pattern.Service;
using BookingAppITDiv.Output;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookingAppITDiv.Services
{
    [ApiController]
    [Route("customer")]
    public class CustomerService : BaseService
    {
        public CustomerService(ILogger<BaseService> logger) : base(logger)
        {
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomersOutput), StatusCodes.Status200OK)]
        
    }
}
