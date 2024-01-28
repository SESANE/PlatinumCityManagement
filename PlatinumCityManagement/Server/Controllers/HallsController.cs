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
    public class HallsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public HallsController(ApplicationDbContext context)
        public HallsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Halls
        [HttpGet]
        //refactored
        //public async Task<ActionResult<IEnumerable<Hall>>> GetHalls()
        public async Task<IActionResult> GetHalls()
        {
            //refactored
            //if (_context.Halls == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Halls.ToListAsync();
            var halls = await _unitOfWork.Halls.GetAll();
            return Ok(halls);
        }

        // GET: api/Halls/5
        [HttpGet("{Id}")]
        //refactored
        //public async Task<ActionResult<Hall>> GetHall(int Id)
        public async Task<IActionResult> GetHalls(int Id)
        {
            /*if (_context.Halls == null)
            {
                return NotFound();
            }*/
            var hall = await _unitOfWork.Halls.Get(q => q.Id == Id);

            if (hall == null)
            {
                return NotFound();
            }

            return Ok(hall);
        }

        // PUT: api/Halls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutHall(int Id, Hall hall)
        {
            if (Id != hall.Id)
            {
                return BadRequest();
            }

            //refactored
            //_context.Entry(hall).State = EntityState.Modified;
            _unitOfWork.Halls.Update(hall);

            try
            {
                //refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //refactored
                //if (!HallExists(Id))
                if (!await HallExists(Id))
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

        // POST: api/Halls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPost]
        public async Task<ActionResult<Hall>> PostHall(Hall hall)
        {
            //refactored
            /*if (_context.Halls == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Halls'  is null.");
            }
              _context.Halls.Add(hall);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Halls.Insert(hall);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetHall", new { hall.Id }, hall);
        }

        // DELETE: api/Halls/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteHall(int Id)
        {
            /*if (_context.Halls == null)
            {
                return NotFound();
            }*/
            //refactored
            //var hall = await _context.Halls.FindAsync(Id);
            var hall = await _unitOfWork.Halls.Get(q => q.Id == Id);
            if (hall == null)
            {
                return NotFound();
            }

            //refactored
            //_context.Halls.Remove(hall);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Halls.Delete(Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //refactored
        //private bool HallExists(int Id)
        private async Task<bool> HallExists(int Id)
        {
            //refactored
            //return (_context.Halls?.Any(e => e.Id == Id)).GetValueOrDefault();
            var hall = await _unitOfWork.Halls.Get(q => q.Id == Id);
            return hall != null;
        }
    }
}
