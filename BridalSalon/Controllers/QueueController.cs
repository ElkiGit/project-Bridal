using BridalSalon.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BridalSalon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        private static int counter = 1;
        private static List<QueueBridal> queues = new List<QueueBridal> { };
        // GET: api/<QueueController>
        [HttpGet]
        public IEnumerable<QueueBridal> Get()
        {
            return queues;
        }
        

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public QueueBridal Get(int id)
        {
            return queues.Find(q=>q.Id==id);
        }

        // POST api/<QueueController>
        [HttpPost]
        public void Post([FromBody] QueueBridal value)
        { 
            value.Id = ++counter;
            queues.Add(value);
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}/date")]
        public void Put(int id, [FromBody] DateTime value)
        {
            QueueBridal q = queues.Find(q => q.Id == id);
            if (q != null)
                q.DateQueue=value;
        }
        [HttpPut("{id}/bridal")]
        public void Put(int id, [FromBody] Bridal value)
        {
            QueueBridal q = queues.Find(q => q.Id == id);
            if (q != null)
                q.bridal = value;
        }
      

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            QueueBridal q=queues.Find(q => q.Id == id);
            if(q!=null)
                queues.Remove(q);
        }
    }
}
