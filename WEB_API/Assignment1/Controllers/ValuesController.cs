using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> _data = new() { "value1", "value2" };

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => Ok(_data);

        // GET: api/values/1
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= _data.Count)
                return NotFound();
            return Ok(_data[id]);
        }

        // POST: api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            _data.Add(value);
            return CreatedAtAction(nameof(Get), new { id = _data.Count - 1 }, value);
        }

        // PUT: api/values/1
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= _data.Count)
                return NotFound();
            _data[id] = value;
            return NoContent();
        }

        // DELETE: api/values/1
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
                return NotFound();
            _data.RemoveAt(id);
            return NoContent();
        }
    }
}
