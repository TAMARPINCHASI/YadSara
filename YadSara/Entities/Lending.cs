namespace YadSara.Entities
{
    public class Lending //השאלה
    {
        public int lendingId { get; set; }
        public DateTime timeLend { get; set; }
        public DateTime deadline { get; set; }

        public bool isReturned { get; set; }
        public int idEquipment { get; set; }

        public string lenderId { get; set; }

        public string borrowerId { get; set; }

        public Lending(int lendingId, DateTime timeLend, DateTime deadline, bool isReturned, int idEquipment, string lenderId, string borrowerId)
        {
            this.lendingId = lendingId;
            this.timeLend = timeLend;
            this.deadline = deadline;
            this.isReturned = isReturned;
            this.idEquipment = idEquipment;
            this.lenderId = lenderId;
            this.borrowerId = borrowerId;
        }
    }
}
