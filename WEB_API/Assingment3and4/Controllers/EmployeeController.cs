using Microsoft.AspNetCore.Mvc;
using Assignment3and4.Models;
using Assignment3and4.Filters;

namespace Assignment3and4.Controllers
{
    [ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase

    {
        private static List<Employee> _employees = GetStandardEmployeeList();

        // GET: api/Employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_employees);
        }
        
        // this is for exception !!
//         [HttpGet]
        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // public ActionResult<List<Employee>> GetAll()
        // {
        //     throw new Exception("Simulated exception for test");

        //     // return Ok(_employees); ← Don't execute this during the test
        // }


        // GET: api/Employee/1
        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<Employee> GetById(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        // GET: api/Employee/name/Robinson
        [HttpGet("name/{name}")]
        public ActionResult<Employee> GetByName(string name)
        {
            var emp = _employees.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        // POST: api/Employee
        [HttpPost]
        public ActionResult<Employee> Add([FromBody] Employee employee)
        {
            employee.Id = _employees.Count + 1;
            _employees.Add(employee);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        // PUT: api/Employee/1
      
[HttpPut("{id}")]
public ActionResult<Employee> Update(int id, [FromBody] Employee updatedEmp)
{
    if (id <= 0)
    {
        return BadRequest("Invalid employee id");
    }

    var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
    if (existingEmp == null)
    {
        return BadRequest("Invalid employee id");
    }

    // Perform update
    existingEmp.Name = updatedEmp.Name;
    existingEmp.Salary = updatedEmp.Salary;
    existingEmp.Permanent = updatedEmp.Permanent;
    existingEmp.Department = updatedEmp.Department;
    existingEmp.Skills = updatedEmp.Skills;
    existingEmp.DateOfBirth = updatedEmp.DateOfBirth;

    return Ok(existingEmp);
}


        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            _employees.Remove(emp);
            return NoContent();
        }

        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Robinson",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "Engineering" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    },
                    DateOfBirth = new DateTime(2000, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Daniel",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Communication" }
                    },
                    DateOfBirth = new DateTime(1998, 5, 15)
                }
            };
        }
    }
}
