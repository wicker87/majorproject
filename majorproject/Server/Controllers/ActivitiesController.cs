﻿using System;
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
    public class ActivitiesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivitiesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Activities
        [HttpGet]
        public async Task<IActionResult>GetActivities()
        {
            var activities = await _unitOfWork.Activities.GetAll();
            return Ok(activities);
        }

        // GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(int id)
        {
            var activity = await _unitOfWork.Activities.Get(q=>q.Id==id);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }

        // PUT: api/Activities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity(int id, Activity activity)
        {
            if (id != activity.Id)
            {
                return BadRequest();
            }

            //_context.Entry(activity).State = EntityState.Modified;
            _unitOfWork.Activities.Update(activity);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ActivityExists(id))
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

        // POST: api/Activities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Activity>> PostActivity(Activity activity)
        {
          
            //_context.Activities.Add(activity);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Activities.Insert(activity);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetActivity", new { id = activity.Id }, activity);
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            
            var activity = await _unitOfWork.Activities.Get(q=>q.Id==id);
            if (activity == null)
            {
                return NotFound();
            }

            //_context.Activities.Remove(activity);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Activities.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> ActivityExists(int id)
        {
            //return (_context.Activities?.Any(e => e.Id == id)).GetValueOrDefault();
            var activity= await _unitOfWork.Activities.Get(q=>q.Id== id);
            return activity != null;
        }
    }
}