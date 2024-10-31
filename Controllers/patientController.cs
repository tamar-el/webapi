using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class patientController : ControllerBase
    {
        private static List<ClassPatient> patients = new List<ClassPatient> {
            new ClassPatient { address="address1",age=111 ,email="ff"},
            new ClassPatient { address="address2",age=111 ,email="ff"}
            };
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<ClassPatient> Get()
        {
            return patients ;
        }

        // GET api/<patientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<patientController>
        [HttpPost]
        public ClassPatient Post([FromBody] ClassPatient value)
        {
            patients.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
