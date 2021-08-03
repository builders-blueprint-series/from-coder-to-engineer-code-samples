namespace FromCodeToEngineer.SampleApp.Controllers
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Requests;
    using Services;

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
            CustomerService = new CustomerService();
        }

        public CustomerService CustomerService { get; set; }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomer request)
        {
            if (request.FirstName == string.Empty || request.LastName == string.Empty || request.Email == string.Empty)
            {
                return BadRequest("Fields may not be empty");
            }

            try
            {
                var customer = CustomerService.AddCustomer(request.FirstName, request.LastName, request.Email);

                return Created(string.Empty, null);
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
