using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string> { "Robinson", "Daniel", "Kumar" };

        // GET: api/emp
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }

        // GET: api/emp/0
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            return Ok(employees[id]);
        }

        // GET: api/emp/name/robinson
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var emp = employees.Find(e => e.ToLower() == name.ToLower());
            if (emp == null)
                return NotFound("Employee not found");

            return Ok(emp);
        }

        // ✅ POST: api/emp (Fixed!)
        [HttpPost]
        public IActionResult Create([FromBody] string name)
        {
            employees.Add(name);
            return Created("", name); // You can also use: return Ok(name);
        }

        // PUT: api/emp/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string name)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            employees[id] = name;
            return NoContent(); // 204
        }

        // DELETE: api/emp/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            employees.RemoveAt(id);
            return NoContent(); // 204
        }
    }
}
