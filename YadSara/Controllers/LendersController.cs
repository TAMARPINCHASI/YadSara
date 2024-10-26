using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using YadSara.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadSara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendersController : ControllerBase
    {

        private static new List<Lender> lenders = new List<Lender>
        {
            new Lender("336353560","Yael Pinchsi", "0583236281","Ben Petahia 20", 1)
        };


        // GET: api/<LenderController>
        [HttpGet]
        public List<Lender> Get()
        {
            return lenders;
        }

        // GET api/<LenderController>/5
        [HttpGet("{id}")]
        public Lender Get(string id)
        {
            return lenders.FirstOrDefault(l => l.lenderId == id);
        }

        // POST api/<LenderController>
        [HttpPost]
        public Lender Post([FromBody] Lender l)
        {
            lenders.Add(l);
            return l;
        }

        // PUT api/<LenderController>/5
        [HttpPut("{id}")]
        public Lender Put(string id, [FromBody] Lender l)
        {
            var index = lenders.FindIndex(x => x.lenderId == id);
            lenders[index].lenderId = id;
            lenders[index].name = l.name;
            lenders[index].phone = l.phone;
            lenders[index].adrress = l.adrress;
            lenders[index].cityId = l.cityId;
            return l;
        }

        // DELETE api/<LenderController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = lenders.FindIndex(x => x.lenderId == id);
            lenders.RemoveAt(index);
        }
    }
}
