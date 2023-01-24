namespace PeanutsTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Expenditure> Expenditures { get; set; }
    }

}
