namespace PeanutsTracker.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }
        public virtual Category Category { get; set; }
    }

}
