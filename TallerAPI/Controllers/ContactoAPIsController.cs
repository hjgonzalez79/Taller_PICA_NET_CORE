using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallerAPI.Models;

namespace TallerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoAPIsController : ControllerBase
    {
        private readonly ContactoAPIContext _context;

        public ContactoAPIsController(ContactoAPIContext context)
        {
            _context = context;
        }

        // GET: api/ContactoAPIs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactoAPI>>> GetContactoAPIs()
        {
            return await _context.ContactoAPIs.ToListAsync();
        }

        // GET: api/ContactoAPIs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactoAPI>> GetContactoAPI(int id)
        {
            var contactoAPI = await _context.ContactoAPIs.FindAsync(id);

            if (contactoAPI == null)
            {
                return NotFound();
            }

            return contactoAPI;
        }

        // PUT: api/ContactoAPIs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactoAPI(int id, ContactoAPI contactoAPI)
        {
            if (id != contactoAPI.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactoAPI).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactoAPIExists(id))
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

        // POST: api/ContactoAPIs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ContactoAPI>> PostContactoAPI(ContactoAPI contactoAPI)
        {
            _context.ContactoAPIs.Add(contactoAPI);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContactoAPI), new { id = contactoAPI.Id }, contactoAPI);
        }

        // DELETE: api/ContactoAPIs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContactoAPI>> DeleteContactoAPI(int id)
        {
            var contactoAPI = await _context.ContactoAPIs.FindAsync(id);
            if (contactoAPI == null)
            {
                return NotFound();
            }

            _context.ContactoAPIs.Remove(contactoAPI);
            await _context.SaveChangesAsync();

            return contactoAPI;
        }

        private bool ContactoAPIExists(int id)
        {
            return _context.ContactoAPIs.Any(e => e.Id == id);
        }
    }
}
