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
    public class RiskAssessmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RiskAssessmentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RiskAssessments
        [HttpGet]
        public async Task<IActionResult> GetRiskAssessments()
        {
            var RiskAssessments = await _unitOfWork.RiskAssessments.GetAll();
            return Ok(RiskAssessments);
        }

        // GET: api/RiskAssessments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskAssessment(int id)
        {
            var RiskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id);

            if (RiskAssessment == null)
            {
                return NotFound();
            }

            return Ok(RiskAssessment);
        }

        // PUT: api/RiskAssessments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskAssessment(int id, RiskAssessment RiskAssessment)
        {
            if (id != RiskAssessment.Id)
            {
                return BadRequest();
            }

            //_context.Entry(RiskAssessment).State = EntityState.Modified;
            _unitOfWork.RiskAssessments.Update(RiskAssessment);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RiskAssessmentExists(id))
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

        // POST: api/RiskAssessments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RiskAssessment>> PostRiskAssessment(RiskAssessment RiskAssessment)
        {

            //_context.RiskAssessments.Add(RiskAssessment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskAssessments.Insert(RiskAssessment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRiskAssessment", new { id = RiskAssessment.Id }, RiskAssessment);
        }

        // DELETE: api/RiskAssessments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskAssessment(int id)
        {

            var RiskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id);
            if (RiskAssessment == null)
            {
                return NotFound();
            }

            //_context.RiskAssessments.Remove(RiskAssessment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskAssessments.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RiskAssessmentExists(int id)
        {
            //return (_context.RiskAssessments?.Any(e => e.Id == id)).GetValueOrDefault();
            var RiskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id);
            return RiskAssessment != null;
        }
    }
}

