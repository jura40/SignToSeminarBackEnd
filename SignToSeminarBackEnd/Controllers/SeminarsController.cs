using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignToSeminarBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarsController : ControllerBase
    {
        // GET: api/Seminars
        [HttpGet]
        public IEnumerable<Seminar> Get()
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var seminars = contaxt.Seminars.ToArray();
                return seminars;
            }
        }

        // GET: api/Seminars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Value";
        }

        // POST: api/Seminars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Seminars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
