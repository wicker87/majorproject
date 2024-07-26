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
using majorproject.Client.Static;
using NuGet.Protocol;

namespace majorproject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlertsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Alerts
        [HttpGet]
        public async Task<IActionResult> GetAlerts()
        {
            var alerts = await _unitOfWork.Alerts.GetAll();

            if (alerts == null)
            {
                return NotFound();
            }

            return Ok(alerts);
        }

        // GET: api/Alerts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlert(int id)
        {
            var alert = await _unitOfWork.Alerts.Get(q => q.Id == id);

            if (alert == null)
            {
                return NotFound();
            }
            return Ok(alert);
        }

        // PUT: api/Alerts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlert(int id, Alert alert)
        {
            if (id != alert.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Alerts.Update(alert);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AlertExists(id))
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

        // POST: api/Alerts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alert>> PostAlert(Alert alert)
        {
            await _unitOfWork.Alerts.Insert(alert);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAlert", new { id = alert.Id }, alert);
        }

        // DELETE: api/Alerts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlert(int id)
        {
            var alert = await _unitOfWork.Alerts.Get(q => q.Id == id);
            if (alert == null)
            {
                return NotFound();
            }

            await _unitOfWork.Alerts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AlertExists(int id)
        {
            var alert = await _unitOfWork.Alerts.Get(q => q.Id == id);
            return alert != null;
        }
    }
}
