using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using majorproject.Server.Data;
using majorproject.Shared.Domain;
using majorproject.Server.IRepository;

namespace majorproject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RAFsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RAFsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RAFs
        [HttpGet]
        public async Task<IActionResult> GetRAFs()
        {
            var rAFs = await _unitOfWork.RAFs.GetAll();
            return Ok(rAFs);
        }

        // GET: api/RAFs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRAF(int id)
        {
            var rAF = await _unitOfWork.RAFs.Get(q => q.Id == id);

            if (rAF == null)
            {
                return NotFound();
            }

            return Ok(rAF);
        }

        // PUT: api/RAFs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRAF(int id, RAF rAF)
        {
            if (id != rAF.Id)
            {
                return BadRequest();
            }

            //_context.Entry(rAF).State = EntityState.Modified;
            _unitOfWork.RAFs.Update(rAF);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RAFExists(id))
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

        // POST: api/RAFs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RAF>> PostRAF(RAF rAF)
        {

            //_context.RAFs.Add(rAF);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RAFs.Insert(rAF);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRAF", new { id = rAF.Id }, rAF);
        }

        // DELETE: api/RAFs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRAF(int id)
        {

            var rAF = await _unitOfWork.RAFs.Get(q => q.Id == id);
            if (rAF == null)
            {
                return NotFound();
            }

            //_context.RAFs.Remove(rAF);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RAFs.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RAFExists(int id)
        {
            //return (_context.RAFs?.Any(e => e.Id == id)).GetValueOrDefault();
            var rAF = await _unitOfWork.RAFs.Get(q => q.Id == id);
            return rAF != null;
        }
    }
}

