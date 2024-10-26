namespace YadSara.Entities
{
    public class Equipment  //ציוד
    {
        public int idEquipment { get; set; }
        public string nameEquipment { get; set; }
        public int quantityInStock { get; set; }
        public int currentQuantity { get; set; }
        public string deposit { get; set; }
        public string lenderId { get; set; }

        public Equipment(int idEquipment, string nameEquipment, int quantityInStock, int currentQuantity, string deposit, string lenderId)
        {
            this.idEquipment = idEquipment;
            this.nameEquipment = nameEquipment;
            this.quantityInStock = quantityInStock;
            this.currentQuantity = currentQuantity;
            this.deposit = deposit;
            this.lenderId = lenderId;
        }
    }
}
