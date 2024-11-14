using clinicProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public RoutesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<RoutesController>
        [HttpGet]
        public  IEnumerable<ClassRoutes> Get()
        {
            return _dataContext.routes;
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
            _dataContext.routes.Add(value);
            return value;
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassRoutes value)
        {
            var index = _dataContext.routes.FindIndex(x => x.idname == id);
            _dataContext.routes[index] = value;
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index=_dataContext.routes.FindIndex(x => x.idname == id);
            _dataContext.routes.RemoveAt(index);
        }
    }
}
