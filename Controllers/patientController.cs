using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class patientController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public patientController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<ClassPatient> Get()
        {
            return _dataContext.patients;
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
            _dataContext.patients.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassPatient value)
        {
            var index = _dataContext.patients.FindIndex(x => x.id == id);
            _dataContext.patients[index] = value;
        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index=_dataContext.patients.FindIndex(x => x.id==id);
            _dataContext.patients.RemoveAt(index);
        }
    }
}
