using Microsoft.AspNetCore.Mvc;
using YadSara.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadSara.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private static new List<Equipment> equipments = new List<Equipment>
        {
            new Equipment(1,"כסא גלגלים",5,3,"50$","214861320")
        };


        // GET: api/<EquipmentController>
        [HttpGet]
        public List<Equipment> Get()
        {
            return equipments;
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{lenderId}")]
        public Equipment Get(string lenderId)
        {
            return equipments.FirstOrDefault(e => e.lenderId == lenderId);
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{id}")]
        public Equipment Get(int idE)
        {
            return equipments.FirstOrDefault(e => e.idEquipment == idE);
        }

        // POST api/<EquipmentController>
        [HttpPost]
        public Equipment Post([FromBody] Equipment e)
        {
            equipments.Add(e);
            return e;
        }

        // PUT api/<EquipmentController>/5
        [HttpPut("{id}")]
        public Equipment Put(int id, [FromBody] Equipment e)
        {
            var index = equipments.FindIndex(x => x.idEquipment == id);
            equipments[index].nameEquipment = e.nameEquipment;
            equipments[index].quantityInStock = e.quantityInStock;
            equipments[index].currentQuantity = e.currentQuantity;
            equipments[index].deposit = e.deposit;
            equipments[index].lenderId = e.lenderId;
            return e;
        }

        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = equipments.FindIndex(e => e.idEquipment == id);
            equipments.RemoveAt(index);
        }
    }
}
