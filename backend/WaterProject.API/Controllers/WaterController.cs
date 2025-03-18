using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaterProject.API.Data;

namespace Mission10Stuart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterController : ControllerBase
    {
        private WaterDbContext _context;

        public WaterController(WaterDbContext temp)
        {
            _context = temp;
        }

        [HttpGet(Name = "GetProject")]
        public IEnumerable<Project> GetProjects()
        {
            var ProjectList = _context.Projects.ToList();

            return (ProjectList);
        }
    }
}