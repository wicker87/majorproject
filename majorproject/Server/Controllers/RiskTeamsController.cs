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
    public class RiskTeamsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RiskTeamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RiskTeams
        [HttpGet]
        public async Task<IActionResult> GetRiskTeams()
        {
            var riskTeams = await _unitOfWork.RiskTeams.GetAll(includes: q => q.Include(x => x.Leader).Include(x => x.Member1)
            .Include(x => x.Member2).Include(x => x.Member3).Include(x => x.Member4).Include(x => x.Member5));
            return Ok(riskTeams);
        }

        // GET: api/RiskTeams/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskTeam(int id)
        {
            var riskTeam = await _unitOfWork.RiskTeams.Get(q => q.Id == id);

            if (riskTeam == null)
            {
                return NotFound();
            }

            return Ok(riskTeam);
        }

        // PUT: api/RiskTeams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskTeam(int id, RiskTeam riskTeam)
        {
            if (id != riskTeam.Id)
            {
                return BadRequest();
            }

            //_context.Entry(riskTeam).State = EntityState.Modified;
            _unitOfWork.RiskTeams.Update(riskTeam);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RiskTeamExists(id))
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

        // POST: api/RiskTeams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RiskTeam>> PostRiskTeam(RiskTeam riskTeam)
        {

            //_context.RiskTeams.Add(riskTeam);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskTeams.Insert(riskTeam);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRiskTeam", new { id = riskTeam.Id }, riskTeam);
        }

        // DELETE: api/RiskTeams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskTeam(int id)
        {

            var riskTeam = await _unitOfWork.RiskTeams.Get(q => q.Id == id);
            if (riskTeam == null)
            {
                return NotFound();
            }

            //_context.RiskTeams.Remove(riskTeam);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskTeams.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RiskTeamExists(int id)
        {
            //return (_context.RiskTeams?.Any(e => e.Id == id)).GetValueOrDefault();
            var riskTeam = await _unitOfWork.RiskTeams.Get(q => q.Id == id);
            return riskTeam != null;
        }
    }
}
