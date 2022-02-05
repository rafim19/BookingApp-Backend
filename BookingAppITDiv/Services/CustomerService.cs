using Binus.WS.Pattern.Output;
using Binus.WS.Pattern.Service;
using BookingAppITDiv.Model;
using BookingAppITDiv.Models.Request;
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
        [ProducesResponseType(typeof(AddEditDeleteCustomerOutput), StatusCodes.Status200OK)]
        public IActionResult AddNewItem([FromBody] MsCustomer Data)
        {
            try
            {
                var objJSON = new AddEditDeleteCustomerOutput();
                objJSON.Success = Helper.CustomerHelper.AddNewCustomer(Data);
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new OutputBase(ex));
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomersOutput), StatusCodes.Status200OK)]
        public IActionResult GetAllCustomer()
        {
            try
            {
                var objJSON = new CustomersOutput();
                objJSON.Customers = Helper.CustomerHelper.GetAllCustomer();
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                var exc = new OutputBase(ex);
                if (ex.Message.Contains("404"))
                {
                    // Taking Status Code
                    exc.ResultCode = int.Parse(ex.Message[..3]);
                    // Taking Error Message
                    exc.ErrorMessage = ex.Message.Remove(0, 4);
                }
                return StatusCode(exc.ResultCode, exc);
            }
        }

        [HttpGet]
        [Route("specific")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SpecificCustomerOutput), StatusCodes.Status200OK)]
        public IActionResult GetSpecificCustomer([FromQuery] int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("404-Please Insert CustomerID");
                }

                var objJSON = new SpecificCustomerOutput();
                objJSON.Customer = Helper.CustomerHelper.GetSpecificCustomer(id);
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                var exc = new OutputBase(ex);
                if (ex.Message.Contains("404"))
                {
                    // Taking Status Code
                    exc.ResultCode = int.Parse(ex.Message[..3]);
                    // Taking Error Message
                    exc.ErrorMessage = ex.Message.Remove(0, 4);
                }
                return StatusCode(exc.ResultCode, exc);
            }
        }

        [HttpPatch]
        [Route("specific")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AddEditDeleteCustomerOutput), StatusCodes.Status200OK)]
        public IActionResult UpdateSpecificCustomer([FromBody] CustomerRequestDTO Data)
        {
            try
            {
                if (Data.CustomerID == 0)
                {
                    throw new Exception("404-Please Insert CustomerID");
                }

                var objJSON = new AddEditDeleteCustomerOutput();
                objJSON.Success = Helper.CustomerHelper.UpdateSpecificCustomer(Data);
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                var exc = new OutputBase(ex);
                if (ex.Message.Contains("404"))
                {
                    // Taking Status Code
                    exc.ResultCode = int.Parse(ex.Message[..3]);
                    // Taking Error Message
                    exc.ErrorMessage = ex.Message.Remove(0, 4);
                }
                return StatusCode(exc.ResultCode, exc);
            }
        }

        [HttpPatch]
        [Route("specific/delete")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AddEditDeleteCustomerOutput), StatusCodes.Status200OK)]
        public IActionResult DeleteSpecificCustomer([FromQuery] int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new Exception("404-Please Insert CustomerID");
                }

                var objJSON = new AddEditDeleteCustomerOutput();
                objJSON.Success = Helper.CustomerHelper.DeleteSpecificCustomer(id);
                return new OkObjectResult(objJSON);
            }
            catch (Exception ex)
            {
                var exc = new OutputBase(ex);
                if (ex.Message.Contains("404"))
                {
                    // Taking Status Code
                    exc.ResultCode = int.Parse(ex.Message[..3]);
                    // Taking Error Message
                    exc.ErrorMessage = ex.Message.Remove(0, 4);
                }
                return StatusCode(exc.ResultCode, exc);
            }
        }
    }
}
