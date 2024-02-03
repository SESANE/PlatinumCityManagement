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
    public class ScreeningsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public ScreeningsController(ApplicationDbContext context)
        public ScreeningsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Screenings
        [HttpGet]
        //refactored
        //public async Task<ActionResult<IEnumerable<Screening>>> GetScreenings()
        public async Task<IActionResult> GetScreenings()
        {
            //refactored
            //if (_context.Screenings == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Screenings.ToListAsync();
            var screenings = await _unitOfWork.Screenings.GetAll(includes: q => q.Include(x => x.Hall).Include(x => x.Movie));
            return Ok(screenings);
        }

        // GET: api/Screenings/5
        [HttpGet("{Id}")]
        //refactored
        //public async Task<ActionResult<Screening>> GetScreening(int Id)
        public async Task<IActionResult> GetScreenings(int Id)
        {
            /*if (_context.Screenings == null)
            {
                return NotFound();
            }*/
            var screening = await _unitOfWork.Screenings.Get(q => q.Id == Id);

            if (screening == null)
            {
                return NotFound();
            }

            return Ok(screening);
        }

        // PUT: api/Screenings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutScreening(int Id, Screening screening)
        {
            if (Id != screening.Id)
            {
                return BadRequest();
            }

            //refactored
            //_context.Entry(screening).State = EntityState.Modified;
            _unitOfWork.Screenings.Update(screening);

            try
            {
                //refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //refactored
                //if (!ScreeningExists(Id))
                if (!await ScreeningExists(Id))
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

        // POST: api/Screenings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPost]
        public async Task<ActionResult<Screening>> PostScreening(Screening screening)
        {
            //refactored
            /*if (_context.Screenings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Screenings'  is null.");
            }
              _context.Screenings.Add(screening);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Screenings.Insert(screening);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetScreening", new { screening.Id }, screening);
        }

        // DELETE: api/Screenings/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteScreening(int Id)
        {
            /*if (_context.Screenings == null)
            {
                return NotFound();
            }*/
            //refactored
            //var screening = await _context.Screenings.FindAsync(Id);
            var screening = await _unitOfWork.Screenings.Get(q => q.Id == Id);
            if (screening == null)
            {
                return NotFound();
            }

            //refactored
            //_context.Screenings.Remove(screening);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Screenings.Delete(Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //refactored
        //private bool ScreeningExists(int Id)
        private async Task<bool> ScreeningExists(int Id)
        {
            //refactored
            //return (_context.Screenings?.Any(e => e.Id == Id)).GetValueOrDefault();
            var screening = await _unitOfWork.Screenings.Get(q => q.Id == Id);
            return screening != null;
        }
    }
}
