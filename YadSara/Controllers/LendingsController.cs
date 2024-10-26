using Microsoft.AspNetCore.Mvc;
using YadSara.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadSara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendingsController : ControllerBase
    {
        private static new List<Lending> lendings = new List<Lending>
        {
            new Lending(1, new DateTime(), new DateTime(),false, 1,"336353560","214861320")
        };


        // GET: api/<LendingsController>
        [HttpGet]
        public List<Lending> Get()
        {
            return lendings;
        }

        // GET api/<LendingsController>/5
        [HttpGet("{lenderId}&{borrowerId}")]
        public List<Lending> Get(string lenderId, string borrowerId)
        {
            return lendings.FindAll(x => x.lenderId == lenderId && x.borrowerId == borrowerId);
        }

        // GET api/<LendingsController>/5
        [HttpGet("{deadline}")]
        public List<Lending> Get(DateTime deadLine)
        {
            return lendings.FindAll(x => x.isReturned == false && x.deadline == deadLine);
        }

        // POST api/<LendingsController>
        [HttpPost]
        public Lending Post([FromBody] Lending l)
        {
            lendings.Add(l);
            return l;
        }

        // PUT api/<LendingsController>/5
        [HttpPut("{id}")]
        public Lending Put(int id, [FromBody] Lending l)
        {
            var index = lendings.FindIndex(x => x.idEquipment == id);
            lendings[index].idEquipment = id;
            lendings[index].timeLend = l.timeLend;
            lendings[index].deadline = l.deadline;
            lendings[index].idEquipment = l.idEquipment;
            lendings[index].isReturned = l.isReturned;
            lendings[index].borrowerId = l.borrowerId;
            lendings[index].lenderId = l.lenderId;
            return l;
        }

        // DELETE api/<LendingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = lendings.FindIndex(x => x.idEquipment == id);
            lendings.RemoveAt(index);
        }
    }
}
