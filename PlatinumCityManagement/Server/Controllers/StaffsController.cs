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
    public class StaffsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //refactored
        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        //refactored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        public async Task<IActionResult> GetStaffs()
        {
            //refactored
            //if (_context.Staffs == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Staffs.ToListAsync();
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{Id}")]
        //refactored
        //public async Task<ActionResult<Staff>> GetStaff(int Id)
        public async Task<IActionResult> GetStaffs(int Id)
        {
            /*if (_context.Staffs == null)
            {
                return NotFound();
            }*/
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == Id);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutStaff(int Id, Staff staff)
        {
            if (Id != staff.Id)
            {
                return BadRequest();
            }

            //refactored
            //_context.Entry(staff).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(staff);

            try
            {
                //refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //refactored
                //if (!StaffExists(Id))
                if (!await StaffExists(Id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkId=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            //refactored
            /*if (_context.Staffs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Staffs'  is null.");
            }
              _context.Staffs.Add(staff);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { staff.Id }, staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStaff(int Id)
        {
            /*if (_context.Staffs == null)
            {
                return NotFound();
            }*/
            //refactored
            //var staff = await _context.Staffs.FindAsync(Id);
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == Id);
            if (staff == null)
            {
                return NotFound();
            }

            //refactored
            //_context.Staffs.Remove(staff);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Delete(Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //refactored
        //private bool StaffExists(int Id)
        private async Task<bool> StaffExists(int Id)
        {
            //refactored
            //return (_context.Staffs?.Any(e => e.Id == Id)).GetValueOrDefault();
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == Id);
            return staff != null;
        }
    }
}
