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
    public class RiskEvaluationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RiskEvaluationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RiskEvaluations
        [HttpGet]
        public async Task<IActionResult> GetRiskEvaluations()
        {
            var riskEvaluations = await _unitOfWork.RiskEvaluations.GetAll();
            return Ok(riskEvaluations);
        }

        // GET: api/RiskEvaluations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRiskEvaluation(int id)
        {
            var riskEvaluation = await _unitOfWork.RiskEvaluations.Get(q => q.Id == id);

            if (riskEvaluation == null)
            {
                return NotFound();
            }

            return Ok(riskEvaluation);
        }

        // PUT: api/RiskEvaluations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiskEvaluation(int id, RiskEvaluation riskEvaluation)
        {
            if (id != riskEvaluation.Id)
            {
                return BadRequest();
            }

            //_context.Entry(riskEvaluation).State = EntityState.Modified;
            _unitOfWork.RiskEvaluations.Update(riskEvaluation);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RiskEvaluationExists(id))
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

        // POST: api/RiskEvaluations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RiskEvaluation>> PostRiskEvaluation(RiskEvaluation riskEvaluation)
        {

            //_context.RiskEvaluations.Add(riskEvaluation);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskEvaluations.Insert(riskEvaluation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRiskEvaluation", new { id = riskEvaluation.Id }, riskEvaluation);
        }

        // DELETE: api/RiskEvaluations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRiskEvaluation(int id)
        {

            var riskEvaluation = await _unitOfWork.RiskEvaluations.Get(q => q.Id == id);
            if (riskEvaluation == null)
            {
                return NotFound();
            }

            //_context.RiskEvaluations.Remove(riskEvaluation);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RiskEvaluations.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RiskEvaluationExists(int id)
        {
            //return (_context.RiskEvaluations?.Any(e => e.Id == id)).GetValueOrDefault();
            var riskEvaluation = await _unitOfWork.RiskEvaluations.Get(q => q.Id == id);
            return riskEvaluation != null;
        }
    }
}