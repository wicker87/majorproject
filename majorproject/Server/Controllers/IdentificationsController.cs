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
    public class IdentificationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public IdentificationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Identifications
        [HttpGet]
        public async Task<IActionResult> GetIdentifications()
        {
            var identifications = await _unitOfWork.Identifications.GetAll();

            if (identifications == null)
            {
                return NotFound();
            }
            return Ok(identifications);
        }

        // GET: api/Identifications/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdentification(int id)
        {
            var identification = await _unitOfWork.Identifications.Get(q => q.Id == id, includes: q => q.Include(x => x.RiskEvaluations));

            if (identification == null)
            {
                return NotFound();
            }
            return Ok(identification);
        }

        // GET: api/Identifications/assessment/5 - Newly Added
        [HttpGet("assessment/{id}")]
        public async Task<IActionResult> GetIdentificationsByAssessment(int id)
        {
            var identifications = await _unitOfWork.Identifications.GetAll(q => q.Activity.AssessmentId == id);
            return Ok(identifications);
        }

        // GET: api/Identifications/activity/5 - Newly Added
        [HttpGet("activity/{id}")]
        public async Task<IActionResult> GetIdentificationsByActivityId(int id)
        {
            var identifications = await _unitOfWork.Identifications.GetAll(q => q.ActivityId == id);
            return Ok(identifications);
        }

        // PUT: api/Identifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdentification(int id, Identification identification)
        {
            if (id != identification.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Identifications.Update(identification);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await IdentificationExists(id))
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

        // POST: api/Identifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Identification>> PostIdentification(Identification identification)
        {
            await _unitOfWork.Identifications.Insert(identification);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetIdentification", new { id = identification.Id }, identification);
        }

        // DELETE: api/Identifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIdentification(int id)
        {
            var identification = await _unitOfWork.Identifications.Get(q => q.Id == id);
            if (identification == null)
            {
                return NotFound();
            }

            await _unitOfWork.Identifications.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> IdentificationExists(int id)
        {
            var identification = await _unitOfWork.Identifications.Get(q => q.Id == id);
            return identification != null;
        }
    }
}
