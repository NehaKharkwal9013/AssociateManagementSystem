using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AmsAPI.Models;

namespace AmsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatesMastersController : ControllerBase
    {
        private readonly AssociateMasterContext _context;

        public AssociatesMastersController(AssociateMasterContext context)
        {
            _context = context;
        }

        // GET: api/AssociatesMasters
        [HttpGet]
        [Route("List")]
        public async Task<ActionResult<IEnumerable<AssociatesMaster>>> GetAssociatesMasters()
        {
            return await _context.AssociatesMasters.ToListAsync();
        }

        // GET: api/AssociatesMasters/5
        [HttpGet]
        [Route("Details")]
        public async Task<ActionResult<AssociatesMaster>> GetAssociatesMaster(int id)
        {
            var associatesMaster = await _context.AssociatesMasters.FindAsync(id);

            if (associatesMaster == null)
            {
                return NotFound();
            }

            return associatesMaster;
        }

        // PUT: api/AssociatesMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("UpdateRecord")]
        public async Task<IActionResult> PutAssociatesMaster(int id, AssociatesMaster associatesMaster)
        {
            if (id != associatesMaster.AssociateId)
            {
                return BadRequest();
            }

            _context.Entry(associatesMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssociatesMasterExists(id))
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

        // POST: api/AssociatesMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("CreateRecord")]
        public async Task<ActionResult<AssociatesMaster>> PostAssociatesMaster(AssociatesMaster associatesMaster)
        {
            _context.AssociatesMasters.Add(associatesMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssociatesMaster", new { id = associatesMaster.AssociateId }, associatesMaster);
        }

        // DELETE: api/AssociatesMasters/5
        [HttpPost]
        [Route("DeleteRecord")]
        public async Task<IActionResult> DeleteAssociatesMaster(int id)
        {
            var associatesMaster = await _context.AssociatesMasters.FindAsync(id);
            if (associatesMaster == null)
            {
                return NotFound();
            }

            _context.AssociatesMasters.Remove(associatesMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssociatesMasterExists(int id)
        {
            return _context.AssociatesMasters.Any(e => e.AssociateId == id);
        }
    }
}
