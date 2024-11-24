using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public ActionResult<Status> Get()
        {
            return Ok(_statusService.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute]int statusId)
        {
            var status = _statusService.GetById(statusId);
            if(status != null) 
                return Ok(status);
            return NotFound();
        }


        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
    }
}
