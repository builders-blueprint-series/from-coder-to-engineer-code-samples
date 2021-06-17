namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using Microsoft.AspNetCore.Mvc;

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
