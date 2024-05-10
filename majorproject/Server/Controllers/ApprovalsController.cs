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
    public class ApprovalsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApprovalsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Approvals
        [HttpGet]
        public async Task<IActionResult> GetApprovals()
        {
            var approvals = await _unitOfWork.Approvals.GetAll();
            return Ok(approvals);
        }

        // GET: api/Approvals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApproval(int id)
        {
            var approval = await _unitOfWork.Approvals.Get(q => q.Id == id);

            if (approval == null)
            {
                return NotFound();
            }

            return Ok(approval);
        }

        // PUT: api/Approvals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApproval(int id, Approval approval)
        {
            if (id != approval.Id)
            {
                return BadRequest();
            }

            //_context.Entry(approval).State = EntityState.Modified;
            _unitOfWork.Approvals.Update(approval);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ApprovalExists(id))
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

        // POST: api/Approvals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Approval>> PostApproval(Approval approval)
        {

            //_context.Approvals.Add(approval);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Approvals.Insert(approval);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApproval", new { id = approval.Id }, approval);
        }

        // DELETE: api/Approvals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApproval(int id)
        {

            var approval = await _unitOfWork.Approvals.Get(q => q.Id == id);
            if (approval == null)
            {
                return NotFound();
            }

            //_context.Approvals.Remove(approval);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Approvals.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> ApprovalExists(int id)
        {
            //return (_context.Approvals?.Any(e => e.Id == id)).GetValueOrDefault();
            var approval = await _unitOfWork.Approvals.Get(q => q.Id == id);
            return approval != null;
        }
    }
}

