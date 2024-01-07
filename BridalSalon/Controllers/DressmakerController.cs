using Bridal.Core.Entities;
using Bridal.Core.Services;
using Bridal.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressmakerController : ControllerBase
    {

        private readonly IDressmakerServices _DressmakerService;

        public DressmakerController(IDressmakerServices DressmakerService)
        {
            _DressmakerService = DressmakerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_DressmakerService.GetDressmaker());
        }

        // GET api/<DressmakerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_DressmakerService.GetDressmakerById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Dressmaker value)
        {
          return Ok(_DressmakerService.AddDressmaker(value));
        }

        // PUT api/<DressmakerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Dressmaker value)
        {
            return Ok(_DressmakerService.UpdateDressmaker(id, value));
        }
        [HttpPut("{id}/Experience")]
        public IActionResult Put(int id, [FromBody] Experience value)
        {
            return Ok(_DressmakerService.UpdateDressmaker(id, value));
        }
        [HttpPut("{id}/Status")]
        public IActionResult Put(int id, [FromBody] int value)
        {
            return Ok(_DressmakerService.UpdateDressmaker(id, value));
        }

        // DELETE api/<DressmakerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _DressmakerService.DeleteDressmaker(id);
        }
    }
}
