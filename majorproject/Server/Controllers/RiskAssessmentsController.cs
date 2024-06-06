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
            var riskAssessments = await _unitOfWork.RiskAssessments.GetAll(includes: q => q.Include(q => q.Team));
            return Ok(riskAssessments);
        }

        // GET: api/RiskAssessments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskAssessment(int id)
        {
            var riskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id, 
                includes: q => q.Include(x => x.Team).Include(x => x.WorkActivities)
                .ThenInclude(x => x.Identifications).ThenInclude(x => x.RiskEvaluations).ThenInclude(x => x.Control));

            if (riskAssessment == null)
            {
                return NotFound();
            }

            return Ok(riskAssessment);
        }

        // PUT: api/RiskAssessments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskAssessment(int id, RiskAssessment riskAssessment)
        {
            if (id != riskAssessment.Id)
            {
                return BadRequest();
            }

            _unitOfWork.RiskAssessments.Update(riskAssessment);

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
        public async Task<ActionResult<RiskAssessment>> PostRiskAssessment(RiskAssessment riskAssessment)
        {
            await _unitOfWork.RiskAssessments.Insert(riskAssessment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRiskAssessment", new { id = riskAssessment.Id }, riskAssessment);
        }

        // DELETE: api/RiskAssessments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskAssessment(int id)
        {

            var riskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id);
            if (riskAssessment == null)
            {
                return NotFound();
            }

            await _unitOfWork.RiskAssessments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RiskAssessmentExists(int id)
        {
            var riskAssessment = await _unitOfWork.RiskAssessments.Get(q => q.Id == id);
            return riskAssessment != null;
        }
    }
}

