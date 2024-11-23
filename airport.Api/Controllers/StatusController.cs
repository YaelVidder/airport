using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }


    [HttpGet]
        public IEnumerable<Status> Get()
        {
            return _statusService.GetList();
        }

        [HttpGet("{id}")]
        public Status Get(int statusId)
        {
            return _statusService.GetList().FirstOrDefault(s => s.statusId == statusId);
        }


        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
    }
}
