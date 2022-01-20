using Microsoft.AspNetCore.Mvc;

namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    [ApiController]
    [Route("api/[controller]")]
    public class BadCustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult ChangeCustomerReservationTime(ChangeCustomerReservationTime request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var handler = ServiceFactory.CustomerService();

            handler.Handle(request);

            return Accepted();
        }
    }
}