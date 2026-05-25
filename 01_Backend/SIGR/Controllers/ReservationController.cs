using Microsoft.AspNetCore.Mvc;

namespace SIGR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetReservations()
        {
            return Ok(new[]
            {
                new {
                    Id = 1,
                    Customer = "Juan",
                    Table = 5
                }
            });
        }
    }
}
