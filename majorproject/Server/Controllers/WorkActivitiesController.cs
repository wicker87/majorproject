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
    public class WorkActivitiesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkActivitiesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/WorkActivities
        [HttpGet]
        public async Task<IActionResult> GetWorkActivities()
        {
            var workActivities = await _unitOfWork.WorkActivities.GetAll();
            return Ok(workActivities);
        }

        // GET: api/WorkActivities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkActivity(int id)
        {
            var workActivity = await _unitOfWork.WorkActivities.Get(q => q.Id == id);

            if (workActivity == null)
            {
                return NotFound();
            }

            return Ok(workActivity);
        }

        // PUT: api/WorkActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkActivity(int id, WorkActivity workActivity)
        {
            if (id != workActivity.Id)
            {
                return BadRequest();
            }

            _unitOfWork.WorkActivities.Update(workActivity);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WorkActivityExists(id))
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

        // POST: api/WorkActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkActivity>> PostWorkActivity(WorkActivity workActivity)
        {
            await _unitOfWork.WorkActivities.Insert(workActivity);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWorkActivity", new { id = workActivity.Id }, workActivity);
        }

        // DELETE: api/WorkActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkActivity(int id)
        {

            var workActivity = await _unitOfWork.WorkActivities.Get(q => q.Id == id);
            if (workActivity == null)
            {
                return NotFound();
            }

            await _unitOfWork.WorkActivities.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WorkActivityExists(int id)
        {
            var workActivity = await _unitOfWork.WorkActivities.Get(q => q.Id == id);
            return workActivity != null;
        }
    }
}
