using Microsoft.AspNetCore.Mvc;
using YadSara.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadSara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowersController : ControllerBase
    {

        private static new List<Borrower> borrowers = new List<Borrower>
        {
            new Borrower("214861320" , "Tami Pinchasi","0583232439", "Ben Petahia 17", 1)
        };

        // GET: api/<BorrowerController>
        [HttpGet]
        public List<Borrower> Get()
        {
            return borrowers;
        }

        // GET api/<BorrowerController>/5
        [HttpGet("{id}")]
        public Borrower Get(string id)
        {
            return borrowers.FirstOrDefault(b => b.borrowerId == id);
        }

        // POST api/<BorrowerController>
        [HttpPost]
        public Borrower Post([FromBody] Borrower b)
        {
            borrowers.Add(b);
            return b;
        }

        // PUT api/<BorrowerController>/5
        [HttpPut("{id}")]
        public Borrower Put(string borrowerId, [FromBody] Borrower b)
        {
            var index = borrowers.FindIndex(x => x.borrowerId == borrowerId);
            borrowers[index].name = b.name;
            borrowers[index].phone = b.phone;
            borrowers[index].adrress = b.adrress;
            borrowers[index].cityId = b.cityId;

            return b;
        }

        // DELETE api/<BorrowerController>/5
        [HttpDelete("{id}")]
        public void Delete(string borrowerId)
        {
            var index = borrowers.FindIndex(b => b.borrowerId == borrowerId);
            borrowers.RemoveAt(index);
        }
    }
}
