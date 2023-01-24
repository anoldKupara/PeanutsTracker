namespace PeanutsTracker.Models
{
    public class UserSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionId { get; set; }
        public DateTime Expiration { get; set; }
        public virtual User User { get; set; }
    }

}
