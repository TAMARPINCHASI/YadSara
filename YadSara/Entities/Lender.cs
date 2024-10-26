namespace YadSara.Entities
{
    public class Lender // משאיל
    {
        public string lenderId { get; set; }
        public string name { get; set; }

        public string phone { get; set; }

        public string adrress { get; set; }

        public int cityId { get; set; }

        public Lender(string lenderId, string name, string phone, string adrress, int cityId)
        {
            this.lenderId = lenderId;
            this.name = name;
            this.phone = phone;
            this.adrress = adrress;
            this.cityId = cityId;
        }
    }
}
