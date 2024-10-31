using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private static List<ClassRoutes> routes =new List<ClassRoutes> {
            new ClassRoutes{Dname="doctor1",idname="patient" },
            new ClassRoutes{Dname="doctor2",idname="patient" }
        };
        // GET: api/<RoutesController>
        [HttpGet]
        public  IEnumerable<ClassRoutes> Get()
        {
            return routes;
        }

        // GET api/<RoutesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<RoutesController>
        [HttpPost]
        public ClassRoutes Post([FromBody] ClassRoutes value)
        {
            routes.Add(value);
            return value;
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
