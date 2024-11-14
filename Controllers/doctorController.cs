using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public doctorController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<doctorController>
        [HttpGet]
        public IEnumerable<ClassDoctor> Get()
        {
            return _dataContext.doctors;
        }

        // GET api/<doctorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<doctorController>
        [HttpPost]
        public ClassDoctor Post([FromBody] ClassDoctor value)
        {
            _dataContext.doctors.Add(value);
            return value;
        }

        // PUT api/<doctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassDoctor value)
        {
            var index= _dataContext.doctors.FindIndex(x => x.id==id);
            _dataContext.doctors[index]=value;
        }

        // DELETE api/<doctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index= _dataContext.doctors.FindIndex(x=>x.id==id);
            _dataContext.doctors.RemoveAt(index);
        }
    }
}
