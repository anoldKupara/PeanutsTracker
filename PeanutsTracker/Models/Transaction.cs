namespace PeanutsTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public virtual Category Category { get; set; }
    }

}
