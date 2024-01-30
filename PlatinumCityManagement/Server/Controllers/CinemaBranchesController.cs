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
    public class CinemaBranchesController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public CinemaBranchesController(ApplicationDbContext context)
        public CinemaBranchesController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/CinemaBranches
        [HttpGet]
        //refactored
        //public async Task<ActionResult<IEnumerable<CinemaBranch>>> GetCinemaBranches()
        public async Task<IActionResult> GetCinemaBranches()
        {
            //refactored
            //if (_context.CinemaBranches == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.CinemaBranches.ToListAsync();
            var cinemaBranches = await _unitOfWork.CinemaBranches.GetAll();
            return Ok(cinemaBranches);
        }

        // GET: api/CinemaBranches/5
        [HttpGet("{Id}")]
        //refactored
        //public async Task<ActionResult<CinemaBranch>> GetCinemaBranch(int Id)
        public async Task<IActionResult> GetCinemaBranches(int Id)
        {
          /*if (_context.CinemaBranches == null)
          {
              return NotFound();
          }*/
            var cinemaBranch = await _unitOfWork.CinemaBranches.Get(q => q.Id == Id);

            if (cinemaBranch == null)
            {
                return NotFound();
            }

            return Ok(cinemaBranch);
        }

        // PUT: api/CinemaBranches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutCinemaBranch(int Id, CinemaBranch cinemaBranch)
        {
            if (Id != cinemaBranch.Id)
            {
                return BadRequest();
            }

            //refactored
            //_context.Entry(cinemaBranch).State = EntityState.Modified;
            _unitOfWork.CinemaBranches.Update(cinemaBranch);

            try
            {
                //refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //refactored
                //if (!CinemaBranchExists(Id))
                if (!await CinemaBranchExists(Id))
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

        // POST: api/CinemaBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPost]
        public async Task<ActionResult<CinemaBranch>> PostCinemaBranch(CinemaBranch cinemaBranch)
        {
          //refactored
          /*if (_context.CinemaBranches == null)
          {
              return Problem("Entity set 'ApplicationDbContext.CinemaBranches'  is null.");
          }
            _context.CinemaBranches.Add(cinemaBranch);
            await _context.SaveChangesAsync();*/
            await _unitOfWork.CinemaBranches.Insert(cinemaBranch);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCinemaBranch", new { cinemaBranch.Id }, cinemaBranch);
        }

        // DELETE: api/CinemaBranches/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCinemaBranch(int Id)
        {
            /*if (_context.CinemaBranches == null)
            {
                return NotFound();
            }*/
            //refactored
            //var cinemaBranch = await _context.CinemaBranches.FindAsync(Id);
            var cinemaBranch = await _unitOfWork.CinemaBranches.Get(q => q.Id == Id);
            if (cinemaBranch == null)
            {
                return NotFound();
            }

            //refactored
            //_context.CinemaBranches.Remove(cinemaBranch);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CinemaBranches.Delete(Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //refactored
        //private bool CinemaBranchExists(int Id)
        private async Task<bool> CinemaBranchExists(int Id)
        {
            //refactored
            //return (_context.CinemaBranches?.Any(e => e.Id == Id)).GetValueOrDefault();
            var cinemaBranch = await _unitOfWork.CinemaBranches.Get(q => q.Id == Id);
            return cinemaBranch != null;
        }
    }
}
