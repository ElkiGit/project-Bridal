using Bridal.Core.Entities;
using Bridal.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BridalController : ControllerBase
    {
        private readonly IBridalServices _BridalService;

        public BridalController(IBridalServices BridalService)
        {
            _BridalService = BridalService;
        }
        // GET: api/<BridalController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BridalService.GetBridals());
        }

        // GET api/<BridalController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bridal = _BridalService.GetById(id);
            if (bridal is null)
            {
                return NotFound();
            }
            return Ok(bridal);
        }


        // POST api/<BridalController>
        [HttpPost]
        public IActionResult Post([FromBody] BridalClass value)
        {
            return Ok(_BridalService.AddBridal(value));
        }

        // PUT api/<BridalController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BridalClass value)
        {
            return Ok(_BridalService.UpdateBridal(id, value));
        }
        [HttpPut("{id}/dressmaker")]

        public IActionResult Put(int id, [FromBody] Dressmaker value)
        {
            return Ok(_BridalService.UpdateBridal(id, value));
        }
        [HttpPut("{id}/date")]
       
        public IActionResult Put(int id, [FromBody] DateTime value)
        {
            return Ok(_BridalService.UpdateBridal(id, value));
        }

        // DELETE api/<BridalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _BridalService.DeleteBridal(id);
        }
    }
}
