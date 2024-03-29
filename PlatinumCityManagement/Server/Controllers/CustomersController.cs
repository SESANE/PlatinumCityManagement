﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatinumCityManagement.Server.Data;
using PlatinumCityManagement.Shared.Domain;

    namespace PlatinumCityManagement.Server.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CustomersController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public CustomersController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/Customers
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
            {
                if (_context.Customers == null)
                {
                    return NotFound();
                }
                return await _context.Customers.ToListAsync();
            }

            // GET: api/Customers/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Customer>> GetCustomer(int id)
            {
                if (_context.Customers == null)
                {
                    return NotFound();
                }
                var Customer = await _context.Customers.FindAsync(id);

                if (Customer == null)
                {
                    return NotFound();
                }

                return Customer;
            }

            // PUT: api/Customers/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutCustomer(int id, Customer Customer)
            {
                if (id != Customer.Id)
                {
                    return BadRequest();
                }

                _context.Entry(Customer).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(id))
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

            // POST: api/Customers
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Customer>> PostCustomer(Customer Customer)
            {
                if (_context.Customers == null)
                {
                    return Problem("Entity set 'ApplicationDbContext.Customers'  is null.");
                }
                _context.Customers.Add(Customer);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCustomer", new { id = Customer.Id }, Customer);
            }

            // DELETE: api/Customers/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCustomer(int id)
            {
                if (_context.Customers == null)
                {
                    return NotFound();
                }
                var Customer = await _context.Customers.FindAsync(id);
                if (Customer == null)
                {
                    return NotFound();
                }

                _context.Customers.Remove(Customer);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool CustomerExists(int id)
            {
                return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
            }
        }
    }

    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
          if (_context.Customers == null)
          {
              return NotFound();
          }
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
          if (_context.Customers == null)
          {
              return NotFound();
          }
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
          if (_context.Customers == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Customers'  is null.");
          }
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
