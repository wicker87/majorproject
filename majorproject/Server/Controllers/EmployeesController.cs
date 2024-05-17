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
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<IActionResult>GetEmployees()
        {
            var employees = await _unitOfWork.Employees.GetAll();
            return Ok(employees);
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _unitOfWork.Employees.Get(q=>q.Id==id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            //_context.Entry(employee).State = EntityState.Modified;
            _unitOfWork.Employees.Update(employee);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await EmployeeExists(id))
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

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
          
            //_context.Employees.Add(employee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Employees.Insert(employee);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            
            var employee = await _unitOfWork.Employees.Get(q=>q.Id==id);
            if (employee == null)
            {
                return NotFound();
            }

            //_context.Employees.Remove(employee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Employees.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> EmployeeExists(int id)
        {
            //return (_context.Employees?.Any(e => e.Id == id)).GetValueOrDefault();
            var employee= await _unitOfWork.Employees.Get(q=>q.Id== id);
            return employee != null;
        }
    }
}
