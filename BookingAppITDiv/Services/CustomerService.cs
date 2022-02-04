using Binus.WS.Pattern.Output;
using Binus.WS.Pattern.Service;
using BookingAppITDiv.Model;
using BookingAppITDiv.Output;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BookingAppITDiv.Services
{
    [ApiController]
    [Route("customer")]
    public class CustomerService : BaseService
    {
        public CustomerService(ILogger<BaseService> logger) : base(logger)
        {
        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomersOutput), StatusCodes.Status200OK)]
        public IActionResult AddNewItem([FromBody] MsCustomer data)
        {
            try
            {
                var objJSON = new AddCustomerOutput();
                objJSON.Success = Helper.CustomerHelper.AddNewCustomer(data);
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new OutputBase(ex));
            }
        }

    }
}
