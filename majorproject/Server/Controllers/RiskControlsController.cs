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
    public class RiskControlsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RiskControlsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RiskControls
        [HttpGet]
        public async Task<IActionResult> GetRiskControls()
        {
            var riskControls = await _unitOfWork.RiskControls.GetAll();
            return Ok(riskControls);
        }

        // GET: api/RiskControls/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskControl(int id)
        {
            var riskControl = await _unitOfWork.RiskControls.Get(q => q.Id == id);

            if (riskControl == null)
            {
                return NotFound();
            }

            return Ok(riskControl);
        }

        // PUT: api/RiskControls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskControl(int id, RiskControl riskControl)
        {
            if (id != riskControl.Id)
            {
                return BadRequest();
            }

            //_context.Entry(riskControl).State = EntityState.Modified;
            _unitOfWork.RiskControls.Update(riskControl);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RiskControlExists(id))
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

        // POST: api/RiskControls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RiskControl>> PostRiskControl(RiskControl riskControl)
        {

            //_context.RiskControls.Add(riskControl);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskControls.Insert(riskControl);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRiskControl", new { id = riskControl.Id }, riskControl);
        }

        // DELETE: api/RiskControls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskControl(int id)
        {

            var riskControl = await _unitOfWork.RiskControls.Get(q => q.Id == id);
            if (riskControl == null)
            {
                return NotFound();
            }

            //_context.RiskControls.Remove(riskControl);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskControls.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RiskControlExists(int id)
        {
            //return (_context.RiskControls?.Any(e => e.Id == id)).GetValueOrDefault();
            var riskControl = await _unitOfWork.RiskControls.Get(q => q.Id == id);
            return riskControl != null;
        }
    }
}
