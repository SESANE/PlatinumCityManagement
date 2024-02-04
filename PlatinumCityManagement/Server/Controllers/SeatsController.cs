using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatinumCityManagement.Server.Data;
using PlatinumCityManagement.Shared.Domain;
using PlatinumCityManagement.Server.IRepository;
using PlatinumCityManagement.Server.Repository;

namespace PlatinumCityManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public SeatsController(ApplicationDbContext context)
        public SeatsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Seats
        [HttpGet]
        //refactored
        //public async Task<ActionResult<IEnumerable<Seat>>> GetSeats()
        public async Task<IActionResult> GetSeats()
        {
            //refactored
            //if (_context.Seats == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Seats.ToListAsync();
            var seats = await _unitOfWork.Seats.GetAll(includes: q => q.Include(x => x.Screening));
            return Ok(seats);
        }

        // GET: api/Seats/5
        [HttpGet("{Id}")]
        //refactored
        //public async Task<ActionResult<Seat>> GetSeat(int Id)
        public async Task<IActionResult> GetSeats(int Id)
        {
            /*if (_context.Seats == null)
            {
                return NotFound();
            }*/
            var seat = await _unitOfWork.Seats.Get(q => q.Id == Id);

            if (seat == null)
            {
                return NotFound();
            }

            return Ok(seat);
        }

        // PUT: api/Seats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutSeat(int Id, Seat seat)
        {
            if (Id != seat.Id)
            {
                return BadRequest();
            }

            //refactored
            //_context.Entry(seat).State = EntityState.Modified;
            _unitOfWork.Seats.Update(seat);

            try
            {
                //refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //refactored
                //if (!SeatExists(Id))
                if (!await SeatExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Seats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPost]
        public async Task<ActionResult<Seat>> PostSeat(Seat seat)
        {
            //refactored
            /*if (_context.Seats == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Seats'  is null.");
            }
              _context.Seats.Add(seat);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Seats.Insert(seat);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSeat", new { seat.Id }, seat);
        }

        // DELETE: api/Seats/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteSeat(int Id)
        {
            /*if (_context.Seats == null)
            {
                return NotFound();
            }*/
            //refactored
            //var seat = await _context.Seats.FindAsync(Id);
            var seat = await _unitOfWork.Seats.Get(q => q.Id == Id);
            if (seat == null)
            {
                return NotFound();
            }

            //refactored
            //_context.Seats.Remove(seat);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Seats.Delete(Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //refactored
        //private bool SeatExists(int Id)
        private async Task<bool> SeatExists(int Id)
        {
            //refactored
            //return (_context.Seats?.Any(e => e.Id == Id)).GetValueOrDefault();
            var seat = await _unitOfWork.Seats.Get(q => q.Id == Id);
            return seat != null;
        }
    }
}
