using Microsoft.AspNetCore.Mvc;
using SIGR.DTOs;

namespace SIGR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private static List<ReservationDto> _reservations = new()
        {
            new ReservationDto { Id = 1, Customer = "Juan", Table = 5 },
            new ReservationDto { Id = 2, Customer = "Acevedo", Table = 6 },
        };

        // GET: api/reservations
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_reservations);
        }

        // GET: api/reservations/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var reservation = _reservations.FirstOrDefault(x => x.Id == id);

            if (reservation == null)
                return NotFound();

            return Ok(reservation);
        }

        // POST: api/reservations
        [HttpPost]
        public IActionResult Create(ReservationDto dto)
        {
            dto.Id = _reservations.Count + 1;
            _reservations.Add(dto);

            return Ok(dto);
        }

        // PUT: api/reservations/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, ReservationDto dto)
        {
            var reservation = _reservations.FirstOrDefault(x => x.Id == id);

            if (reservation == null)
                return NotFound();

            reservation.Customer = dto.Customer;
            reservation.Table = dto.Table;

            return Ok(reservation);
        }

        // DELETE: api/reservations/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reservation = _reservations.FirstOrDefault(x => x.Id == id);

            if (reservation == null)
                return NotFound();

            _reservations.Remove(reservation);

            return Ok();
        }
    }
}
