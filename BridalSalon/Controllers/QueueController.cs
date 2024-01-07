
using Bridal.Core.Entities;
using Bridal.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly IQueueBridalServices _queueBridalServices;
        public QueueController(IQueueBridalServices queueBridalServices)
        {
            _queueBridalServices = queueBridalServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_queueBridalServices.GetQueue());
        }


        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_queueBridalServices.GetQueueById(id));
        }

        // POST api/<QueueController>
        [HttpPost]
        public IActionResult Post([FromBody] QueueBridal value)
        {
           return Ok(_queueBridalServices.AddQueue(value));
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public IActionResult Put(int id, [FromBody] DateTime value)
        {
           return Ok(_queueBridalServices.UpdetQueue(id, value));
        }
        [HttpPut("{id}/bridal")]
        public IActionResult Put(int id, [FromBody] BridalClass value)
        {
            return Ok(_queueBridalServices.UpdetQueue(id, value));
        }


        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _queueBridalServices.DeleteQueue(id);
        }
    }
}
