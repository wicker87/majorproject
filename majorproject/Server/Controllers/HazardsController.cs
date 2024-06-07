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
    public class HazardsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public HazardsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Hazards
        [HttpGet]
        public async Task<IActionResult> GetHazards()
        {
            var hazards = await _unitOfWork.Hazards.GetAll();

            if(hazards == null)
            {
                return NotFound();
            }

            return Ok(hazards);
        }

        // GET: api/Hazards/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHazard(int id)
        {
            var hazard = await _unitOfWork.Hazards.Get(q => q.Id == id);

            if (hazard == null)
            {
                return NotFound();
            }
            return Ok(hazard);
        }

        // PUT: api/Hazards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHazard(int id, Hazard hazard)
        {
            if (id != hazard.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Hazards.Update(hazard);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await HazardExists(id))
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

        // POST: api/Hazards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hazard>> PostHazard(Hazard hazard)
        {
            await _unitOfWork.Hazards.Insert(hazard);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetHazard", new { id = hazard.Id }, hazard);
        }

        // DELETE: api/Hazards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHazard(int id)
        {
            var hazard = await _unitOfWork.Hazards.Get(q => q.Id == id);
            if (hazard == null)
            {
                return NotFound();
            }

            await _unitOfWork.Hazards.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> HazardExists(int id)
        {
            var hazard = await _unitOfWork.Hazards.Get(q => q.Id == id);
            return hazard != null;
        }
    }
}
