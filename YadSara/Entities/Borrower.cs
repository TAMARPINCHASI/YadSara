namespace YadSara.Entities
{
    public class Borrower //שואל
    {
        public string borrowerId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public string adrress { get; set; }
        public int cityId { get; set; }

        public Borrower(string borrowerId, string name, string phone, string address, int cityId)
        {
            this.borrowerId = borrowerId;
            this.name = name;
            this.phone = phone;
            this.adrress = address;
            this.cityId = cityId;
        }
    }
}
