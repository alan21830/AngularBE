using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCourseDotNet.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularCourseDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Context _db;
        public ValuesController(Context db)
        {
            _db = db;
        }




        // GET api/values
        [HttpGet]
       
        public IActionResult getAll ()


        {
            var val = _db.Values.ToList();
           return Ok(val); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            var value = _db.Values.FirstOrDefault(a=>a.Id==id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
