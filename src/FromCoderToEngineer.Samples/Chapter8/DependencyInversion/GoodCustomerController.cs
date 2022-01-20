using Microsoft.AspNetCore.Mvc;

namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoodCustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public GoodCustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult ChangeCustomerReservationTime(ChangeCustomerReservationTime request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _customerService.Handle(request);

            return Accepted();
        }
    }
}