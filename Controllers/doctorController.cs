using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorController : ControllerBase
    {
        private static List<ClassDoctor> doctors =new List<ClassDoctor> {
           new ClassDoctor{name="name1",id=12345678},
           new ClassDoctor{name="name2",id=12345678}
            };
        // GET: api/<doctorController>
        [HttpGet]
        public IEnumerable<ClassDoctor> Get()
        {
            return doctors;
        }

        // GET api/<doctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<doctorController>
        [HttpPost]
        public ClassDoctor Post([FromBody] ClassDoctor value)
        {
            doctors.Add(value);
            return value;
        }

        // PUT api/<doctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassDoctor value)
        {
            var index=doctors.FindIndex(x => x.id==id);
            doctors[index]=value;
        }

        // DELETE api/<doctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
