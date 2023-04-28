using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapidubaidemos.Data;
using webapidubaidemos.Models;


namespace webapidubaidemos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewapiController : ControllerBase
    {
        private readonly DataContext _dt;

        public NewapiController(DataContext dt)
        {
            this._dt = dt;
        }
        [HttpGet("getemployee")]
            public List<Employee> getemp()
        {
            return _dt.getempoyees();
        }
    }
}
